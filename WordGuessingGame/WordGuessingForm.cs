using System.Collections;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WordGuessingGame
{
    public partial class WordGuessingForm : Form
    {
        int attemptsCounter = 0;

        public WordGuessingForm()
        {
            InitializeComponent();

        }
        private void WordGuessingForm_Load(object sender, EventArgs e)
        {

            //Placeholder
            txtInput.PlaceholderText = "Enter Word";
            //Words and Hints
            String[] GuessWords = { "classroom", "sharpener", "whiteboard" };
            String[] hints = { "*Hint: a learning space.", "*Hint: device that makes something sharp.", "*Hint: a surface used for teaching." };

            Random rnd = new Random();
            //Randomly select a Word and Hints
            int selectedWordIndex = rnd.Next(GuessWords.Length);
            String selectedWord = GuessWords[selectedWordIndex];
            String hint = hints[selectedWordIndex];
            StringBuilder sb = new StringBuilder(selectedWord);

            //Replace all letters with '?'
            for (int i = 0; i < 8; i++)
            {
                int index = rnd.Next(sb.Length);
                sb[index] = '?';
            }
            lblWords.Text = sb.ToString();
            lblHints.Text = hint;
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            attemptsCounter++;
            //Answers
            ArrayList Answers = new ArrayList();
            Answers.Add("classroom");
            Answers.Add("sharpener");
            Answers.Add("whiteboard");

            String guessedWord = txtInput.Text;

            if (Answers.Contains(guessedWord))
            {
                lblWords.Text = guessedWord;
                MessageBox.Show("Congratulations! You guessed the correct word.","Congrats!",MessageBoxButtons.OK);
                attemptsCounter = 0;
                lblAttemps.Text = attemptsCounter.ToString("Attemps: " + attemptsCounter);
            }
            else
            {
                MessageBox.Show("Wrong! Try agian.","Wrong!", MessageBoxButtons.OK);
                lbWrongGuess.Items.Add("*" + txtInput.Text + "*");
                lblAttemps.Text = attemptsCounter.ToString("Attemps: " + attemptsCounter);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            WordGuessingForm_Load(sender, e);
            lbWrongGuess.Items.Clear();
            txtInput.Text = "";
            attemptsCounter = 0;
            lblAttemps.Text = attemptsCounter.ToString("Attemps: "+ attemptsCounter);
        }
    }
}
