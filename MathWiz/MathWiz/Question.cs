﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    /*  Kevin's note:
     *  I thought about this for a while. Should we split questions into multiple classes?
     *  Such as multiple choice questions exending off of the base question class, 
     *  and having randomly generated questions and customized questions be their own classes?
     *  However, I decided against it because it was going to make the Test and Grade classes a lot more complicated
     *  Instead, I have just provided multiple different constructors that will make it act like their own unique objects.
     *  This is an important decision, and if we get it wrong, it could cost a lot of time, so we need to talk it over.
     */

    /*I was looking at 12 mastery levels
     * 1. simple addition
     * 2. simple subtraction
     * 3. simple mixed add, sub
     * 7. simple multiplication
     * 8. simple division
     * 9. mixed mult, div
     * 4. complex addition
     * 5. complex sub
     * 6. complex mixed add, sub
     * 10. advanced mult
     * 11. advanced div
     * 13. advanced mixed mult, div*/


    public class Question
    {
        public int Id { get; set; }
        public int MasteryLevel { get; set; }
        public string QuestionText { get; set; }
        public List<RadioButton> Choices { get; set; }
        public int CorrectAnswer { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public int Weight { get; set; }
        public bool RandomlyGenerated { get; set; }


        //declare a list of question objects that will later be fed back  to the test
        private static Random rnd = new Random();
        private static List<int> easyRandoms = new List<int>();
        private static List<int> hardRandoms = new List<int>();
        private static List<Question> testQuestions = new List<Question>();
        //empty constructor
        public Question() { }

        //normal constructor randomly generated
        public Question(int masteryLevel, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = null; //TODO call method to generate question based on masterylevel
            this.Choices = null;
            this.CorrectAnswer = CorrectAnswer; //TODO call method to generate answer based on question (or it will also be set during generation of question)
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = true;
        }

        //normal custom constructor no choices
        public Question(string questionText, string correctAnswer, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = 0; //TODO calculate the mastery level based on the question that was submitted by the teacher
            this.QuestionText = questionText;
            this.Choices = null;
            this.CorrectAnswer = CorrectAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = false;
        }

        //normal custom constructor with choices
        public Question(string questionText, List<RadioButton> choices, string correctAnswer, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = 0; //TODO calculate the mastery level based on the question that was submitted by the teacher
            this.QuestionText = questionText;
            this.Choices = choices;
            this.CorrectAnswer = CorrectAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = false;
        }

        //full constructor
        public Question(int masteryLevel, string questionText, List<RadioButton> choices, string correctAnswer, TimeSpan timeLimit, int weight, bool randomlyGenerated)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = questionText;
            this.Choices = choices;
            this.CorrectAnswer = CorrectAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = randomlyGenerated;
        }
        /*stuff*/
         private List<Question> GenerateQuestions(int masteryLevel)
        {
            return testQuestions;
        }

        public static List<int> GenerateEasyRandomNumbers()
        {

            easyRandoms = Enumerable.Range(0, 10).OrderBy(x => rnd.Next()).Take(10).ToList();
            return easyRandoms;
        }

        public static List<int> GenerateHardRandomNumbers()
        {
            Random rnd = new Random();
            hardRandoms = Enumerable.Range(10, 10).OrderBy(x => rnd.Next()).Take(10).ToList();
            return hardRandoms;
        }

        /*I was looking at 12 mastery levels
 * 1. simple addition
 * 2. simple subtraction
 * 3. simple mixed add, sub
 * 4. complex addition
 * 5. complex sub
 * 6. complex mixed add, sub
 * 7. simple multiplication
 * 8. simple division
 * 9. mixed mult, div
 * 10. advanced mult
 * 11. advanced div
 * 13. advanced mixed mult, div*/

        public static List<Question> GenerateRandomQuestions(int masteryLevel, TimeSpan timeLimit)
        {
            List<Question> qL = new List<Question>();
            

            int caseswitch = masteryLevel;
            switch(masteryLevel)
            {
                case 1:
                    qL = GenerateSimpleAddtionQuestions();
                    break;
                case 2:
                    //qL = GenerateSimpleSubtractionQuestions();
                    break;
                case 3:
                    //qL = GenerateMixed
                    break;
                case 4:
                    Console.WriteLine("Case4");
                    break;
                case 5:
                    Console.WriteLine("Case5");
                    break;
                case 6:
                    Console.WriteLine("Case6");
                    break;
                case 7:
                    Console.WriteLine("Case7");
                    break;
                case 8:
                    Console.WriteLine("Case8");
                    break;
                case 9:
                    Console.WriteLine("Case9");
                    break;
                case 10:
                    Console.WriteLine("Case10");
                    break;
                case 11:
                    Console.WriteLine("Case11");
                    break;
                case 12:
                    Console.WriteLine("Case12");
                    break;
                case 13:
                    Console.WriteLine("Case13");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
                    

            }
            return qL;

        }


        public static List<Question> GenerateSimpleAddtionQuestions()
        {
            TimeSpan Standard = new TimeSpan(0, 1, 0);
            string questionText;
            List<int> firstEasy = GenerateEasyRandomNumbers();
            List<int> secondEasy = GenerateEasyRandomNumbers();
            var firstEasyEnumerator = firstEasy.GetEnumerator();
            int[] answer = new int[10];
            var secondEasyEnumerator = secondEasy.GetEnumerator();
            var answerEnumerator = answer.GetEnumerator();
            //enumerate through the lists
            while(firstEasyEnumerator.MoveNext())
            {
                int counter = 0;
                secondEasyEnumerator.MoveNext();
                answerEnumerator.MoveNext();
                answer[counter] = ((firstEasyEnumerator.Current) + (secondEasyEnumerator.Current));
                questionText = firstEasyEnumerator.Current.ToString() + " + " + secondEasyEnumerator.Current.ToString() + " = ";
                //MessageBox.Show("FirstNumber: " + firstEasyEnumerator.Current.ToString() + "\n" +
                //                "SecondNumber: " + secondEasyEnumerator.Current.ToString() + "\n" +
                //                "Answer: " + answer[counter].ToString() + "\n" +
                //                "theText: " + questionText);
                Question question = new Question();
                question.QuestionText = questionText;
                question.CorrectAnswer = answer[counter];
                question.TimeLimit = Standard;
                counter++;
                testQuestions.Add(question);
            }

            foreach(Question q in testQuestions)
            {
                MessageBox.Show(q.QuestionText + q.CorrectAnswer.ToString());
            }
            return testQuestions;

        }
    }
}
