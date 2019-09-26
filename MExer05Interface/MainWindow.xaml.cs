using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MExer05;
using MExer02;
using System.Timers;

namespace MExer05Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.MainViewModel;
        }

        Timer timer = new Timer();

        private void TbxPegAName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Peg tempStart = CmbStart.SelectedItem as Peg;
            Peg tempEnd = CmbEnd.SelectedItem as Peg;

            ViewModelLocator.MainViewModel.ListPeg.Clear();
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.A);
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.B);
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.C);

            CmbStart.SelectedItem = tempStart;
            CmbEnd.SelectedItem = tempEnd;
        }

        private void TbxPegBName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Peg tempStart = CmbStart.SelectedItem as Peg;
            Peg tempEnd = CmbEnd.SelectedItem as Peg;

            ViewModelLocator.MainViewModel.ListPeg.Clear();
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.A);
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.B);
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.C);

            CmbStart.SelectedItem = tempStart;
            CmbEnd.SelectedItem = tempEnd;
        }

        private void TbxPegCName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Peg tempStart = CmbStart.SelectedItem as Peg;
            Peg tempEnd = CmbEnd.SelectedItem as Peg;

            ViewModelLocator.MainViewModel.ListPeg.Clear();
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.A);
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.B);
            ViewModelLocator.MainViewModel.ListPeg.Add(ViewModelLocator.MainViewModel.C);

            CmbStart.SelectedItem = tempStart;
            CmbEnd.SelectedItem = tempEnd;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {        
            if (LbInstructions.Items.Count != 0)
                ViewModelLocator.MainViewModel.MoveRing(ViewModelLocator.MainViewModel.ListInstructions2[ViewModelLocator.MainViewModel.InstructionLine]);

            if (ViewModelLocator.MainViewModel.InstructionLine != ViewModelLocator.MainViewModel.NumOfInstructions - 2)
                ViewModelLocator.MainViewModel.InstructionLine++;
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (LbInstructions.Items.Count != 0)
            {
                ViewModelLocator.MainViewModel.ReverseMoveRing(ViewModelLocator.MainViewModel.ListInstructions2[ViewModelLocator.MainViewModel.InstructionLine]);
            }

            if (ViewModelLocator.MainViewModel.InstructionLine != 0)
                ViewModelLocator.MainViewModel.InstructionLine--;         
        }

        private void TbNumDisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            timer = new Timer();
            ViewModelLocator.MainViewModel.SetNumDisk();
            LbInstructions.Items.Clear();
        }

        private void CmbStart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            ViewModelLocator.MainViewModel.SetNumDisk();
            ViewModelLocator.MainViewModel.SetAuxPeg();
            LbInstructions.Items.Clear();
        }

        private void CmbEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewModelLocator.MainViewModel.SetAuxPeg();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            timer = new Timer();
            ViewModelLocator.MainViewModel.SetNumDisk();
            ViewModelLocator.MainViewModel.AddDisksToStart();
            ViewModelLocator.MainViewModel.ListInstructions2.Clear();
            ViewModelLocator.MainViewModel.NumOfInstructions = 1;
            ViewModelLocator.MainViewModel.EnqueueInstructions(ViewModelLocator.MainViewModel.NumDisks, ViewModelLocator.MainViewModel.StartPeg, ViewModelLocator.MainViewModel.AuxPeg, ViewModelLocator.MainViewModel.EndPeg);
            ViewModelLocator.MainViewModel.InstructionLine = 0;

            LbInstructions.Items.Clear();
            while (ViewModelLocator.MainViewModel.ListInstructions.Count != 0)
            {
                LbInstructions.Items.Add(ViewModelLocator.MainViewModel.NumOfInstructions.ToString() + ") " + ViewModelLocator.MainViewModel.ListInstructions.Dequeue());
                ViewModelLocator.MainViewModel.NumOfInstructions++;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            timer = new Timer();
            ViewModelLocator.MainViewModel.NextPrev = true;
            ViewModelLocator.MainViewModel.Play = false;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.MainViewModel.NextPrev = false;
            ViewModelLocator.MainViewModel.Play = true;
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            timer = new Timer();
            timer.Interval = Convert.ToInt16(TbDelay.Text);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (LbInstructions.Items.Count != 0)
                ViewModelLocator.MainViewModel.MoveRing(ViewModelLocator.MainViewModel.ListInstructions2[ViewModelLocator.MainViewModel.InstructionLine]);

            if (ViewModelLocator.MainViewModel.InstructionLine != ViewModelLocator.MainViewModel.NumOfInstructions - 2)
                ViewModelLocator.MainViewModel.InstructionLine++;
        }

        private void SliderDelay_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (timer.Enabled == true)
            {
                timer.Interval = Convert.ToInt16(TbDelay.Text);
            }
        }
    }
}
