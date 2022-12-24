using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280_Assignment_5
{
    public class Game
    {
        //correct counter
        public int Correct { get; set; }
        //incorrect counter
        public int Incorrect { get; set; }
        //time variable
        public double Time { get; set; }
        //round counter
        public int QuestionNum { get; set; }
        //answer
        public int Answer; 
        //operator
        public string op; 

        //GameWindow initializer
        GameWindow GameWindowForm;

        /// <summary>
        /// Take in the type of game
        /// Start a clean slate
        /// </summary>
        /// 
        public void startGame(string Operator)
        {
            //Set everything to a number
            Correct = 0;
            Incorrect = 0;
            Time = 0;
            QuestionNum = 1;
            Answer = 0;

            op = Operator; 

            //Call generateRound
            generateRound(op); 
        }

        public void generateRound(string Operator)
        {
            if(QuestionNum > 10)
            {
                GameWindowForm.end_game(); 
            }

            //pass random numbers and operator into generateQuestion
            Random rand = new Random();
            int rand1 = rand.Next();
            int rand2 = rand.Next();
            
            generateQuestion(Operator, rand1, rand2); 
        }
        /// <summary>
        /// Class to generate question and answer
        /// Gets called from the generate rand class
        /// </summary>
        /// 
        public string generateQuestion(string Operator, int rand1, int rand2)
        {            
            if(Operator.Equals("add"))
            {
                //If the operator is addition, pefrom addition to find the answer 
                Answer = rand1 + rand2; 
                return "What is " + rand1 + " + " + rand2 + "?"; 
            }
            else if(Operator.Equals("subtract"))
            {
                //If the operator is subtraction, pefrom subtraction to find the answer
                if (rand1 > rand2)
                {
                    //Making sure that there are no negative answers
                    Answer = rand1 - rand2; 
                    return "What is " + rand1 + " - " + rand2 + "?";
                } else
                {
                    Answer = rand2 - rand1; 
                    return "What is " + rand2 + " - " + rand1 + "?";
                }
            }else if(Operator.Equals("multiply"))
            {
                //If the operator is multiplication, pefrom multiplication to find the answer 
                Answer = rand1 * rand2;
                return "What is " + rand1 + " * " + rand2 + "?";
            }else
            {
                //If the operator is division, pefrom division to find the answer 
                if (rand1 > rand2 && (rand1 % rand2) == 0)
                {
                    //Making sure that the numbers are divisible
                    Answer = rand1 / rand2; 
                    return "What is " + rand1 + " / " + rand2 + "?"; 
                }else if (rand2 > rand1 && (rand2 % rand1) == 0)
                {
                    Answer = rand2 / rand1; 
                }else
                {
                    //If not, perform recursion
                    generateRound(Operator); 
                }
            }
            return "error"; 
        }


        /// <summary>
        /// Boolean class that will return whether student's answer was correct or not
        /// Update correct or incorrect count
        /// Update round counter
        /// </summary>
        /// 
        public Boolean isCorrect (int studentAnswer)
        {
            //Regardless, update questionNum
            QuestionNum++; 

            //If correct, return true and update correctNum
            if(studentAnswer == Answer)
            {
                Correct++;
                return true;       
            }else
            {
                //Else, update Incorrect
                Incorrect++; 
            }
            //Will only hit if not true
            return false; 
        }


        /// <summary>
        /// Timer handler
        /// </summary>
        /// 
    }
}
