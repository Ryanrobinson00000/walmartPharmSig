using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walmartPharmSig
{
    public partial class sectionTest : UserControl
    {

        //list of questions
        List<String> questions = new List<String>();
        //list of answers
        List<String> answers = new List<String>();
        //keeps track of the question number
        int questionCounter = 0;
        //stores number of questions user didnt skip and got right eventually
        int notSkipped = 0;
        //stores number of incorrect guesses, which is used to determine whether the first guess is correct
        int incorrectGuess = 0;
        //stores number of questions user got right without getting it wrong first
        int firstGuessCorrect = 0;
        
        public sectionTest()
        {
            //performs sets questions to common questions if sectiontest pathway is followed
            List<String> commonQuestions = new List<String>();
            commonQuestions.Add("Common");


            InitializeComponent();
            
            //gets questions commonquestions textfile using Common.txt
            getQuestions(commonQuestions);

            //creates a random gernator
            Random rng = new Random();
            //shuffles questions
            shuffle(questions, answers, rng);
            //allows for & to be used
            answer.UseMnemonic = false;
            directions.UseMnemonic = false;

            //sets label to common sigs test
            titleLabel.Text = "Common Sigs Test";

            //sets question to the firstquestion
            directions.Text = questions[0];
            //hidden answer text to the correct answer
            answer.Text = "Correct answer:" + answers[0];
            //sts question label text
            setQuestionTextLabel();

            //disables ability to go back to select options as you would with the section test
            goBack.Visible = false;
        }
        //initiates panel if sectiontest pathway is followed
        public sectionTest(List<String> checkBoxChosen)
        {
            
            InitializeComponent();
            //gets questions using the checkboxes selected on sectionoptions panel
            getQuestions(checkBoxChosen);
            //creates a randomizer
            Random rng = new Random();
            //shuffles questions
            shuffle(questions, answers, rng);
            //allows & to be used
            answer.UseMnemonic = false;
            directions.UseMnemonic = false;

            //sets title label
            titleLabel.Text = "Sig Section Test";
            //sets first question text
                directions.Text =questions[0];
            //sets first answer text, it is invisible
            answer.Text = "Correct answer:"+answers[0];
            //sets question text label
            setQuestionTextLabel();

        
        }

        //when go back button is pressed goes to section options panel
        private void goBack_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["sectionOptions"].BringToFront();
         
        }
        //when main menu button is pressed goes to main menu panel
        private void toMainMenu_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["main"].BringToFront();

        }
        //ges questions from file
        private void getQuestions(List<String> filesChosen)
        {
           
            //file directory format @"\Data\Names.txt"

            //reades list of chosen files
            for (int x=0;x<filesChosen.Count;x++)
            {
                //reads file as a series of lines
                string[] lines = System.IO.File.ReadAllLines(@"SectionFiles\"+filesChosen[x]+".txt");
                //creates a counter to keep track of file lines
                int count = 0;
                //iterates through lines in file
                foreach (string line in lines)
                {
                    //if the file is an even line add it to the questions list
                    if(count%2==0)
                    {
                        questions.Add(line);
                    }
                    //if the file is an odd line add it to the answers list
                    else
                    {
                        answers.Add(line);
                    }

                    //increments even odd counter because next line will be iterated through if available
                    count++;
                }
            }
        }

        //shuffles questions
        void shuffle(List<String> questions,List<String> answers, Random rng)
        {
            //stores number of questions
            int n = questions.Count;
            //while there more than 1 or questions available
            while (n > 1)
            {
                //deincrments question count
                n--;
                //gets next randoim value as k
                int k = rng.Next(n + 1);
                //stores the question value of k in question value
                String qvalue = questions[k];
                //swaps question values
                questions[k] = questions[n];
                questions[n] = qvalue;

                //stores answer value of k index in answer value
                String avalue = answers[k];
                //swaps answer values
                answers[k] = answers[n];
                answers[n] = avalue;
            }
        }
        //sets question text label for answered questions out of total questions
        void setQuestionTextLabel()
        {
           
            questionCount.Text = (questionCounter+1).ToString() + " of " + questions.Count + " questions";

        }
        //checks question when submit is pressed
        private void Submit_Click(object sender, EventArgs e)
        {
            //checks if users answer is equal to the correct answer
            //formats as uppercase for user answer
            if(userAnswerTextBox.Text.ToUpper()==answers[questionCounter])
            {
                //increment that the question wasnt skipped and display new value becaue ansewr was right
                notSkipped++;
                notSkippedLabel.Text = "Not Skipped " + notSkipped + " of " + (questionCounter+1);

                //determines if next guess is wrong
                if(incorrectGuess==0)
                {
                    firstGuessCorrect++;
                }
                //resets incorrect guess for next question
                incorrectGuess = 0;
                //displays first time right ratio
                firstTimeCorrect.Text = "First Time Correct: " + firstGuessCorrect + " of " + (questionCounter + 1);


                //disables user inputs and allows user to see answer and go to next question
                Next.Enabled = true;
                userAnswerTextBox.Enabled = false;
                rightWrong.Visible = true;
                rightWrong.Text = "CORRECT";
                Submit.Enabled = false;
                skip.Enabled = false;
                answer.Visible = true;

                //if the question count is equal to the number of questions, the test is over and allow user to restart test if desired
                if(questionCounter+1==questions.Count)
                {//disables ability to go to next question because there are no more questions
                    Next.Enabled = false;
                    //enable user ability to restart test
                    restart.Visible = true;
                }
            }
            else
            {
                //if answer was incorrect increment incorrect guess number
                incorrectGuess++;
                //notify user that the answer was wrong and make it visible to viewer
                rightWrong.Visible = true;
                rightWrong.Text = "incorrect please try again";

            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //increments question counter, allowing to go to next question
            questionCounter++;
            //sets next question
            directions.Text = questions[questionCounter];
        //sets correct answer
            answer.Text = "Correct answer:" + answers[questionCounter];
           //sets the question label
            setQuestionTextLabel();

            //disables ability to go to next question
            Next.Enabled = false;
            //enables user to input answer
            userAnswerTextBox.Enabled = true;
            //disables notification that the answer is right or wrong
            rightWrong.Visible = false;
            rightWrong.Text = "CORRECT";
            //allows usre to submit answer
            Submit.Enabled = true;
            //allows user to skip question
            skip.Enabled = true;
            //hides answer
            answer.Visible = false;

            //resets answer box
            userAnswerTextBox.Text = "";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            //when test restarts resets everything

            //sets number of not skipped questions to 0
            notSkipped = 0;
            notSkippedLabel.Text = "Not Skipped: 0 of 0";

            //sets number of first time correct guesses to 0
            firstGuessCorrect = 0;
            firstTimeCorrect.Text = "First Time Correct: 0 of 0";

            //sets question counter to 0
            questionCounter = 0;

            //makes new random generator
            Random rng = new Random();
            //reshufles questions
            shuffle(questions, answers, rng);

            //sets question label
            setQuestionTextLabel();

            //disables ability to go to next question
            Next.Enabled = false;
            //allows user to type answer to question
            userAnswerTextBox.Enabled = true;
            //makes whether question was right or wrong invisible
            rightWrong.Visible = false;
            //enables submission
            Submit.Enabled = true;
            //enables ability to skip question
            skip.Enabled = true;
            //hides answer to question
            answer.Visible = false;
            //sets text for next question
            directions.Text = questions[questionCounter];
            //sets corresponding question answer
            answer.Text = "Correct answer:" + answers[questionCounter];
            //sets user answer to empty
            userAnswerTextBox.Text = "";
            //disables ability to restart because test is restarted
            restart.Visible = false;
        }
        //protocal for when a question is skipped
        private void skip_Click(object sender, EventArgs e)
        {
           //sets the label for question not skipped  to the current question number
            notSkippedLabel.Text = "Not Skipped " + notSkipped + " of " + (questionCounter + 1);

            //sets the label for first time correct ansers to first time guess counter to the current question number
            firstTimeCorrect.Text = "First Time Correct: " + firstGuessCorrect + " of " + (questionCounter + 1);

            //enables ability to press next question button
            Next.Enabled = true;
            //disables uer input
                userAnswerTextBox.Enabled = false;
            //notifies user question was skipped
                rightWrong.Visible = true;
                rightWrong.Text = "Question Skipped";
            //disables ability to submit answers
                Submit.Enabled = false;
            //disables ability to skip question (it was already skipped)
                skip.Enabled = false;
            //makes answer visible
                answer.Visible = true;
            //if the current question was the last question, disable ability to go to next question and allow user to restart the test
            if (questionCounter + 1 == questions.Count)
            {
                Next.Enabled = false;
                restart.Visible = true;

            } }

        
    }
}
