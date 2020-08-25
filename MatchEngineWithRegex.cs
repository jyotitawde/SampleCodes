using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


public class MatchEngine : Form 
{

    Button buttonMatch  = new Button();
 
   TextBox txtMain = new TextBox();
    TextBox txtSub = new TextBox();
 
    Label labelMainText = new Label();
    Label labelSubText = new Label();
    

    public MatchEngine() 
    {

        buttonMatch.Location = new Point(50, 100);
        buttonMatch.Text = "Match";
        buttonMatch.Click += new System.EventHandler(this. buttonMatch_Click);
        this.Controls.Add(buttonMatch);

        txtMain.Location = new Point(10, 20);
        txtMain.Size = new Size(150, 10);
        this.Controls.Add(txtMain);

        txtSubText.Location = new Point(10, 60);
        txtSubText.Size = new Size(150, 10);
        this.Controls.Add(txtSubText);
        
        labelMainText.Location = new Point(10, 5);
        labelMainText.Size = new Size(144, 15);
        labelMainText.Text = "Main Text";
        this.Controls.Add(labelMainText);

        labelSubText.Location = new Point(10, 45);
        labelSubText.Size = new Size(144, 15);
        labelSubText.Text = "Match Text";
        this.Controls.Add(labelSubText);

    }

    private void buttonMatch _Click(object sender, System.EventArgs e) 
    {

        string strMainText = txtMain.text;
        string strSubText = txtSub.text;

        if ((string.IsNullOrEmpty(strMainText)) || ((string.IsNullOrEmpty(strSubText)))
        {    
            Console.WriteLine("Incorrect Data provided.");      
        } 
        else 
        { 
	        If (strMainText.Length > strSubText.Length)
	        {
                try
                {
                    foreach (Match match in Regex.Matches(strMainText,strSubText, RegexOptions.IgnoreCase))
         		  		Console.WriteLine("Found '{0}' at position {1}", match.Value,match.Index);
                }
                catch (RegexMatchTimeoutException)
                {
	                Console.WriteLine("No match found.");
                }
	        }
	        else
            {
	            Console.WriteLine("Main text must be longer than subtext.");
            }
        }
    }

    public static void Main(string[] args) 
    {
        Application.Run(new MatchEngine());
    }
}

