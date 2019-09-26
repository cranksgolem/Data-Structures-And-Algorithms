using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MExer05;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.ComponentModel;
using MExer05;
using MExer02;

namespace MExer05Interface
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Peg _a = new Peg("A");
        private Peg _b = new Peg("B");
        private Peg _c = new Peg("C");
        private ObservableCollection<Peg> _listPeg = new ObservableCollection<Peg>();
        private QueueUsingDoublyLinkedList<string> _listInstructions = new QueueUsingDoublyLinkedList<string>();
        private List<string> _listInstructions2 = new List<string>();

        public List<string> ListInstructions2
        {
            get { return _listInstructions2; }
            set { _listInstructions2 = value; }
        }

        public QueueUsingDoublyLinkedList<string> ListInstructions
        {
            get { return _listInstructions; }
            set { _listInstructions = value; }
        }

        public ObservableCollection<Peg> ListPeg
        {
            get { return _listPeg; }
            set { _listPeg = value; }
        }

        public Peg A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Peg B
        {
            get { return _b; }
            set { _b = value; }
        }

        public Peg C
        {
            get { return _c; }
            set { _c = value; }
        }

        //Initialize Viewmodel
        public MainViewModel()
        {
            ListPeg.Add(A);
            ListPeg.Add(B);
            ListPeg.Add(C);
            StartPeg = A;
            AuxPeg = B;
            EndPeg = C;
            NumDisks = 3;
            SetAuxPeg();
            AddDisksToStart();
            InstructionLine = 0;
            NumOfInstructions = 1;
        }

        //Shared Values
        public Peg StartPeg { get; set; }
        public Peg EndPeg { get; set; }
        public Peg AuxPeg { get; set; }
        public int NumDisks { get; set; }
        public int InstructionLine { get; set; }
        public int NumOfInstructions { get; set; }

        //Sets the Aux Peg
        public void SetAuxPeg()
        {
            if((StartPeg == A || StartPeg == B) && (EndPeg == A || EndPeg == B))
            {
                AuxPeg = C;
            }

            else if ((StartPeg == B || StartPeg == B) && (EndPeg == C || EndPeg == C))
            {
                AuxPeg = A;
            }

            else if ((StartPeg == A || StartPeg == A) && (EndPeg == C || EndPeg == C))
            {
                AuxPeg = B;
            }
        }

        //Puts instructions in ListInstructions and ListInstructions2
        public void EnqueueInstructions(int n, Peg startPeg, Peg auxPeg, Peg endPeg)
        {
            if (n == 1)
            {
                ListInstructions.Enqueue(HanoiStep.PrintStep(startPeg.PegStack.Peek(), startPeg, endPeg));
                ListInstructions2.Add(HanoiStep.PrintStep2(startPeg.PegStack.Peek(), startPeg, endPeg));
                endPeg.PegStack.Push(startPeg.PegStack.Pop());
            }

            else
            {
                EnqueueInstructions(n - 1, startPeg, endPeg, auxPeg);
                EnqueueInstructions(1, startPeg, auxPeg, endPeg);
                EnqueueInstructions(n - 1, auxPeg, startPeg, endPeg);
            }
        }

        //Moves rectangles by changing visibility property
        public void MoveRing(string input)
        {
            int diskNum = 0;
            string fromName = "";
            string toName = "";

            diskNum = Convert.ToInt16(input.Substring(0, 2));
            int index = 2;
            if (Char.IsWhiteSpace(input[index]) == true)
            {
                index++;
            }

            while (char.IsWhiteSpace(input[index]) != true)
            {
                fromName += input[index];
                index++;
            }

            index++;

            while(index != input.Length)
            {
                toName += input[index];
                index++;
            }
            
            if (diskNum == 1)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec1AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec1BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec1CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec1AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec1BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec1CVis = true;
                }
            }

            else if (diskNum == 2)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec2AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec2BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec2CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec2AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec2BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec2CVis = true;
                }
            }

            else if (diskNum == 3)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec3AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec3BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec3CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec3AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec3BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec3CVis = true;
                }
            }

            else if (diskNum == 4)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec4AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec4BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec4CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec4AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec4BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec4CVis = true;
                }
            }

            else if (diskNum == 5)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec5AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec5BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec5CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec5AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec5BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec5CVis = true;
                }
            }

            else if (diskNum == 6)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec6AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec6BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec6CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec6AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec6BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec6CVis = true;
                }
            }

            else if (diskNum == 7)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec7AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec7BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec7CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec7AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec7BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec7CVis = true;
                }
            }

            else if (diskNum == 8)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec8AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec8BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec8CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec8AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec8BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec8CVis = true;
                }
            }

            else if (diskNum == 9)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec9AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec9BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec9CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec9AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec9BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec9CVis = true;
                }
            }

            else if (diskNum == 10)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec10AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec10BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec10CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec10AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec10BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec10CVis = true;
                }
            }

            else if (diskNum == 11)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec11AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec11BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec11CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec11AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec11BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec11CVis = true;
                }
            }

            else if (diskNum == 12)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec12AVis = false;
                }

                else if (fromName == B.Name)
                {
                    Rec12BVis = false;
                }

                else if (fromName == C.Name)
                {
                    Rec12CVis = false;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec12AVis = true;
                }

                else if (toName == B.Name)
                {
                    Rec12BVis = true;
                }

                else if (toName == C.Name)
                {
                    Rec12CVis = true;
                }
            }
        }

        public void ReverseMoveRing(string input)
        {
            int diskNum = 0;
            string fromName = "";
            string toName = "";

            diskNum = Convert.ToInt16(input.Substring(0, 2));
            int index = 2;
            if (Char.IsWhiteSpace(input[index]) == true)
            {
                index++;
            }

            while (char.IsWhiteSpace(input[index]) != true)
            {
                fromName += input[index];
                index++;
            }

            index++;

            while (index != input.Length)
            {
                toName += input[index];
                index++;
            }


            if (diskNum == 1)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec1AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec1BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec1CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec1AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec1BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec1CVis = false;
                }
            }

            else if (diskNum == 2)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec2AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec2BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec2CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec2AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec2BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec2CVis = false;
                }
            }

            else if (diskNum == 3)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec3AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec3BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec3CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec3AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec3BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec3CVis = false;
                }
            }

            else if (diskNum == 4)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec4AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec4BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec4CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec4AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec4BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec4CVis = false;
                }
            }

            else if (diskNum == 5)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec5AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec5BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec5CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec5AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec5BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec5CVis = false;
                }
            }

            else if (diskNum == 6)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec6AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec6BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec6CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec6AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec6BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec6CVis = false;
                }
            }

            else if (diskNum == 7)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec7AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec7BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec7CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec7AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec7BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec7CVis = false;
                }
            }

            else if (diskNum == 8)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec8AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec8BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec8CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec8AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec8BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec8CVis = false;
                }
            }

            else if (diskNum == 9)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec9AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec9BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec9CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec9AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec9BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec9CVis = false;
                }
            }

            else if (diskNum == 10)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec10AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec10BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec10CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec10AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec10BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec10CVis = false;
                }
            }

            else if (diskNum == 11)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec11AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec11BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec11CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec11AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec11BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec11CVis = false;
                }
            }

            else if (diskNum == 12)
            {
                //"Removes" ring from start Peg
                if (fromName == A.Name)
                {
                    Rec12AVis = true;
                }

                else if (fromName == B.Name)
                {
                    Rec12BVis = true;
                }

                else if (fromName == C.Name)
                {
                    Rec12CVis = true;
                }

                //"Places" ring on end Peg
                if (toName == A.Name)
                {
                    Rec12AVis = false;
                }

                else if (toName == B.Name)
                {
                    Rec12BVis = false;
                }

                else if (toName == C.Name)
                {
                    Rec12CVis = false;
                }
            }
        }

        private bool _nextPrev = true;
        public bool NextPrev
        {
            get
            {
                return _nextPrev;
            }

            set
            {
                _nextPrev = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NextPrev"));
            }
        }

        private bool _play = false;
        public bool Play
        {
            get
            {
                return _play;
            }

            set
            {
                _play = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Play"));
            }
        }
        
        //These will be bound to the visibility property of the rectangles
        //For Peg A
        private bool _rec1AVis = false;
        public bool Rec1AVis
        {
            get
            {
                return _rec1AVis;
            }

            set
            {
                _rec1AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec1AVis"));
            }
        }

        private bool _rec2AVis = false;
        public bool Rec2AVis
        {
            get
            {
                return _rec2AVis;
            }

            set
            {
                _rec2AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec2AVis"));
            }
        }

        private bool _rec3AVis = false;
        public bool Rec3AVis
        {
            get
            {
                return _rec3AVis;
            }

            set
            {
                _rec3AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec3AVis"));
            }
        }

        private bool _rec4AVis = false;
        public bool Rec4AVis
        {
            get
            {
                return _rec4AVis;
            }

            set
            {
                _rec4AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec4AVis"));
            }
        }

        private bool _rec5AVis = false;
        public bool Rec5AVis
        {
            get
            {
                return _rec5AVis;
            }

            set
            {
                _rec5AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec5AVis"));
            }
        }

        private bool _rec6AVis = false;
        public bool Rec6AVis
        {
            get
            {
                return _rec6AVis;
            }

            set
            {
                _rec6AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec6AVis"));
            }
        }

        private bool _rec7AVis = false;
        public bool Rec7AVis
        {
            get
            {
                return _rec7AVis;
            }

            set
            {
                _rec7AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec7AVis"));
            }
        }

        private bool _rec8AVis = false;
        public bool Rec8AVis
        {
            get
            {
                return _rec8AVis;
            }

            set
            {
                _rec8AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec8AVis"));
            }
        }

        private bool _rec9AVis = false;
        public bool Rec9AVis
        {
            get
            {
                return _rec9AVis;
            }

            set
            {
                _rec9AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec9AVis"));
            }
        }

        private bool _rec10AVis = false;
        public bool Rec10AVis
        {
            get
            {
                return _rec10AVis;
            }

            set
            {
                _rec10AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec10AVis"));
            }
        }

        private bool _rec11AVis = false;
        public bool Rec11AVis
        {
            get
            {
                return _rec11AVis;
            }

            set
            {
                _rec11AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec11AVis"));
            }
        }

        private bool _rec12AVis = false;
        public bool Rec12AVis
        {
            get
            {
                return _rec12AVis;
            }

            set
            {
                _rec12AVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec12AVis"));
            }
        }

        //For Peg C
        private bool _rec1CVis = false;
        public bool Rec1CVis
        {
            get
            {
                return _rec1CVis;
            }

            set
            {
                _rec1CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec1CVis"));
            }
        }

        private bool _rec2CVis = false;
        public bool Rec2CVis
        {
            get
            {
                return _rec2CVis;
            }

            set
            {
                _rec2CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec2CVis"));
            }
        }

        private bool _rec3CVis = false;
        public bool Rec3CVis
        {
            get
            {
                return _rec3CVis;
            }

            set
            {
                _rec3CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec3CVis"));
            }
        }

        private bool _rec4CVis = false;
        public bool Rec4CVis
        {
            get
            {
                return _rec4CVis;
            }

            set
            {
                _rec4CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec4CVis"));
            }
        }

        private bool _rec5CVis = false;
        public bool Rec5CVis
        {
            get
            {
                return _rec5CVis;
            }

            set
            {
                _rec5CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec5CVis"));
            }
        }

        private bool _rec6CVis = false;
        public bool Rec6CVis
        {
            get
            {
                return _rec6CVis;
            }

            set
            {
                _rec6CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec6CVis"));
            }
        }

        private bool _rec7CVis = false;
        public bool Rec7CVis
        {
            get
            {
                return _rec7CVis;
            }

            set
            {
                _rec7CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec7CVis"));
            }
        }

        private bool _rec8CVis = false;
        public bool Rec8CVis
        {
            get
            {
                return _rec8CVis;
            }

            set
            {
                _rec8CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec8CVis"));
            }
        }

        private bool _rec9CVis = false;
        public bool Rec9CVis
        {
            get
            {
                return _rec9CVis;
            }

            set
            {
                _rec9CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec9CVis"));
            }
        }

        private bool _rec10CVis = false;
        public bool Rec10CVis
        {
            get
            {
                return _rec10CVis;
            }

            set
            {
                _rec10CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec10CVis"));
            }
        }

        private bool _rec11CVis = false;
        public bool Rec11CVis
        {
            get
            {
                return _rec11CVis;
            }

            set
            {
                _rec11CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec11CVis"));
            }
        }

        private bool _rec12CVis = false;
        public bool Rec12CVis
        {
            get
            {
                return _rec12CVis;
            }

            set
            {
                _rec12CVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec12CVis"));
            }
        }

        //For Peg B
        private bool _rec1BVis = false;
        public bool Rec1BVis
        {
            get
            {
                return _rec1BVis;
            }

            set
            {
                _rec1BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec1BVis"));
            }
        }

        private bool _rec2BVis = false;
        public bool Rec2BVis
        {
            get
            {
                return _rec2BVis;
            }

            set
            {
                _rec2BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec2BVis"));
            }
        }

        private bool _rec3BVis = false;
        public bool Rec3BVis
        {
            get
            {
                return _rec3BVis;
            }

            set
            {
                _rec3BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec3BVis"));
            }
        }

        private bool _rec4BVis = false;
        public bool Rec4BVis
        {
            get
            {
                return _rec4BVis;
            }

            set
            {
                _rec4BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec4BVis"));
            }
        }

        private bool _rec5BVis = false;
        public bool Rec5BVis
        {
            get
            {
                return _rec5BVis;
            }

            set
            {
                _rec5BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec5BVis"));
            }
        }

        private bool _rec6BVis = false;
        public bool Rec6BVis
        {
            get
            {
                return _rec6BVis;
            }

            set
            {
                _rec6BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec6BVis"));
            }
        }

        private bool _rec7BVis = false;
        public bool Rec7BVis
        {
            get
            {
                return _rec7BVis;
            }

            set
            {
                _rec7BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec7BVis"));
            }
        }

        private bool _rec8BVis = false;
        public bool Rec8BVis
        {
            get
            {
                return _rec8BVis;
            }

            set
            {
                _rec8BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec8BVis"));
            }
        }

        private bool _rec9BVis = false;
        public bool Rec9BVis
        {
            get
            {
                return _rec9BVis;
            }

            set
            {
                _rec9BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec9BVis"));
            }
        }

        private bool _rec10BVis = false;
        public bool Rec10BVis
        {
            get
            {
                return _rec10BVis;
            }

            set
            {
                _rec10BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec10BVis"));
            }
        }

        private bool _rec11BVis = false;
        public bool Rec11BVis
        {
            get
            {
                return _rec11BVis;
            }

            set
            {
                _rec11BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec11BVis"));
            }
        }

        private bool _rec12BVis = false;
        public bool Rec12BVis
        {
            get
            {
                return _rec12BVis;
            }

            set
            {
                _rec12BVis = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rec12BVis"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, e);
            }
        }

        //Adds Disks to start Peg
        public void AddDisksToStart()
        {
            for (int x = NumDisks; x > 0; x--)
            {
                StartPeg.PegStack.Push(new Disk(x));
            }
        }

        //Sets the number of disks to be solved
        public void SetNumDisk()
        {
            ListInstructions.Clear();
            ListInstructions2.Clear();
            if (StartPeg == A)
            {
                Rec1AVis = false;
                Rec2AVis = false;
                Rec3AVis = false;
                Rec4AVis = false;
                Rec5AVis = false;
                Rec6AVis = false;
                Rec7AVis = false;
                Rec8AVis = false;
                Rec9AVis = false;
                Rec10AVis = false;
                Rec11AVis = false;
                Rec12AVis = false;

                Rec1BVis = false;
                Rec2BVis = false;
                Rec3BVis = false;
                Rec4BVis = false;
                Rec5BVis = false;
                Rec6BVis = false;
                Rec7BVis = false;
                Rec8BVis = false;
                Rec9BVis = false;
                Rec10BVis = false;
                Rec11BVis = false;
                Rec12BVis = false;

                Rec1CVis = false;
                Rec2CVis = false;
                Rec3CVis = false;
                Rec4CVis = false;
                Rec5CVis = false;
                Rec6CVis = false;
                Rec7CVis = false;
                Rec8CVis = false;
                Rec9CVis = false;
                Rec10CVis = false;
                Rec11CVis = false;
                Rec12CVis = false;

                if (NumDisks == 1)
                {
                    Rec1AVis = true;
                }

                if (NumDisks == 2)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                }

                if (NumDisks == 3)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                }

                if (NumDisks == 4)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                }

                if (NumDisks == 5)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                }

                if (NumDisks == 6)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                }

                if (NumDisks == 7)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                    Rec7AVis = true;
                }

                if (NumDisks == 8)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                    Rec7AVis = true;
                    Rec8AVis = true;
                }

                if (NumDisks == 9)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                    Rec7AVis = true;
                    Rec8AVis = true;
                    Rec9AVis = true;
                }

                if (NumDisks == 10)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                    Rec7AVis = true;
                    Rec8AVis = true;
                    Rec9AVis = true;
                    Rec10AVis = true;
                }

                if (NumDisks == 11)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                    Rec7AVis = true;
                    Rec8AVis = true;
                    Rec9AVis = true;
                    Rec10AVis = true;
                    Rec11AVis = true;
                }

                if (NumDisks == 12)
                {
                    Rec1AVis = true;
                    Rec2AVis = true;
                    Rec3AVis = true;
                    Rec4AVis = true;
                    Rec5AVis = true;
                    Rec6AVis = true;
                    Rec7AVis = true;
                    Rec8AVis = true;
                    Rec9AVis = true;
                    Rec10AVis = true;
                    Rec11AVis = true;
                    Rec12AVis = true;
                }
            }

            else if (StartPeg == B)
            {
                Rec1AVis = false;
                Rec2AVis = false;
                Rec3AVis = false;
                Rec4AVis = false;
                Rec5AVis = false;
                Rec6AVis = false;
                Rec7AVis = false;
                Rec8AVis = false;
                Rec9AVis = false;
                Rec10AVis = false;
                Rec11AVis = false;
                Rec12AVis = false;

                Rec1BVis = false;
                Rec2BVis = false;
                Rec3BVis = false;
                Rec4BVis = false;
                Rec5BVis = false;
                Rec6BVis = false;
                Rec7BVis = false;
                Rec8BVis = false;
                Rec9BVis = false;
                Rec10BVis = false;
                Rec11BVis = false;
                Rec12BVis = false;

                Rec1CVis = false;
                Rec2CVis = false;
                Rec3CVis = false;
                Rec4CVis = false;
                Rec5CVis = false;
                Rec6CVis = false;
                Rec7CVis = false;
                Rec8CVis = false;
                Rec9CVis = false;
                Rec10CVis = false;
                Rec11CVis = false;
                Rec12CVis = false;

                if (NumDisks == 1)
                {
                    Rec1BVis = true;
                }

                if (NumDisks == 2)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                }

                if (NumDisks == 3)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                }

                if (NumDisks == 4)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                }

                if (NumDisks == 5)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                }

                if (NumDisks == 6)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                }

                if (NumDisks == 7)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                    Rec7BVis = true;
                }

                if (NumDisks == 8)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                    Rec7BVis = true;
                    Rec8BVis = true;
                }

                if (NumDisks == 9)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                    Rec7BVis = true;
                    Rec8BVis = true;
                    Rec9BVis = true;
                }

                if (NumDisks == 10)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                    Rec7BVis = true;
                    Rec8BVis = true;
                    Rec9BVis = true;
                    Rec10BVis = true;
                }

                if (NumDisks == 11)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                    Rec7BVis = true;
                    Rec8BVis = true;
                    Rec9BVis = true;
                    Rec10BVis = true;
                    Rec11BVis = true;
                }

                if (NumDisks == 12)
                {
                    Rec1BVis = true;
                    Rec2BVis = true;
                    Rec3BVis = true;
                    Rec4BVis = true;
                    Rec5BVis = true;
                    Rec6BVis = true;
                    Rec7BVis = true;
                    Rec8BVis = true;
                    Rec9BVis = true;
                    Rec10BVis = true;
                    Rec11BVis = true;
                    Rec12BVis = true;
                }
            }

            else if (StartPeg == C)
            {
                Rec1AVis = false;
                Rec2AVis = false;
                Rec3AVis = false;
                Rec4AVis = false;
                Rec5AVis = false;
                Rec6AVis = false;
                Rec7AVis = false;
                Rec8AVis = false;
                Rec9AVis = false;
                Rec10AVis = false;
                Rec11AVis = false;
                Rec12AVis = false;

                Rec1BVis = false;
                Rec2BVis = false;
                Rec3BVis = false;
                Rec4BVis = false;
                Rec5BVis = false;
                Rec6BVis = false;
                Rec7BVis = false;
                Rec8BVis = false;
                Rec9BVis = false;
                Rec10BVis = false;
                Rec11BVis = false;
                Rec12BVis = false;

                Rec1CVis = false;
                Rec2CVis = false;
                Rec3CVis = false;
                Rec4CVis = false;
                Rec5CVis = false;
                Rec6CVis = false;
                Rec7CVis = false;
                Rec8CVis = false;
                Rec9CVis = false;
                Rec10CVis = false;
                Rec11CVis = false;
                Rec12CVis = false;

                if (NumDisks == 1)
                {
                    Rec1CVis = true;
                }

                if (NumDisks == 2)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                }

                if (NumDisks == 3)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                }       

                if (NumDisks == 4)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                }

                if (NumDisks == 5)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                }

                if (NumDisks == 6)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                }

                if (NumDisks == 7)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                    Rec7CVis = true;
                }

                if (NumDisks == 8)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                    Rec7CVis = true;
                    Rec8CVis = true;
                }

                if (NumDisks == 9)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                    Rec7CVis = true;
                    Rec8CVis = true;
                    Rec9CVis = true;
                }

                if (NumDisks == 10)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                    Rec7CVis = true;
                    Rec8CVis = true;
                    Rec9CVis = true;
                    Rec10CVis = true;
                }

                if (NumDisks == 11)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                    Rec7CVis = true;
                    Rec8CVis = true;
                    Rec9CVis = true;
                    Rec10CVis = true;
                    Rec11CVis = true;
                }

                if (NumDisks == 12)
                {
                    Rec1CVis = true;
                    Rec2CVis = true;
                    Rec3CVis = true;
                    Rec4CVis = true;
                    Rec5CVis = true;
                    Rec6CVis = true;
                    Rec7CVis = true;
                    Rec8CVis = true;
                    Rec9CVis = true;
                    Rec10CVis = true;
                    Rec11CVis = true;
                    Rec12CVis = true;
                }
            }
        }

    }

    public static class ViewModelLocator
    {
        private static MainViewModel _mainViewModel;

        public static MainViewModel MainViewModel
        {
            get
            {
                if(_mainViewModel == null)
                {
                    _mainViewModel = new MainViewModel();
                }
                return _mainViewModel;
            }
        }
    }
}
