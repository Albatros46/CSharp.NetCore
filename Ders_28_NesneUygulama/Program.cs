using System;

namespace Ders_28_NesneUygulama
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
//OOP Quiz Uygulaması
    class Question{
        public Question(string text, string[] choices, string answer)
        {
            this.Text=text;
            this.Choices=choices;
            this.Answer=answer;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }//secenekler
        public string Answer { get; set; }//cevap
        public int QuestionsIndex{ get; set; }
        public string checkAnswer(string answer){
             return this.Answer=answer;
        }
       
        
    }
     class Quiz{
            public Quiz(Question[] questions ){
                this.Questions=questions;
                this.QuestionIndex=0;
            }
            private Question[] Questions { get; set; }
            public int QuestionIndex{get; set;}
            public Question GetQuestion(){
                return this.QuestionIndex[this.QuestionIndex];
            }
            public void DisplayQuestion(){
                var qustion=this.GetQuestion();
                Console.WriteLine($"{this.QuestionIndex+1}: {q.Text}");
                foreach (var c in qustion.Choices)
                {
                    Console.WriteLine($"-{c}");
                }
                Console.Write("Cevap :");
                var cevap=Console.ReadLine();
                //Console.WriteLine(qustion.checkAnswer(cevap));
                this.Guess(cevap);
            }
            public void Guess(string answer){
                var qustion=this.GetQuestion();
                Console.WriteLine();

            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var q1=new Question("En iyi Programlama Dili :",new string[]{"C#","Java","Python","C++"},"Java");
            var q2=new Question("En popüler Programlama Dili :",new string[]{"C#","Java","Python","C++"},"Python");
            var q3=new Question("En en çok kazandıran Programlama Dili :",new string[]{"C#","Java","Python","C++"},"Java");
            
            var question=new Question[]{q1,q2,q3};
            var quiz=new Quiz(questions);
            quiz.DisplayQuestion();
            Console.WriteLine(quiz.GetQuestion().Text);
            quiz.QuestionIndex++;
            Console.WriteLine(quiz.GetQuestion().Text);
            quiz.QuestionIndex++;
            Console.WriteLine(quiz.GetQuestion().Text);
            quiz.QuestionIndex++;

            // Console.WriteLine(q1.checkAnswer("C#"));
            // Console.WriteLine(q2.checkAnswer("Java"));
            // Console.WriteLine(q3.checkAnswer("Python"));
            //int index=1;
            // foreach (var q in question)
            // {
            //     Console.WriteLine($"Soru {index}: {q.Text}");
            //     index++;
            //     foreach (var c in q.Choices)
            //     {
            //         Console.WriteLine($"Cevap -{c}");
            //     }
            //     Console.WriteLine("Cevap :");
            //     var cevap=Console.ReadLine();
            //     Console.WriteLine(q.checkAnswer(cevap));
            // }
        }
    }
}
