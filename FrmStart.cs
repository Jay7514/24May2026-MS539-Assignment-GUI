//Here we can add our libraries we will use
//for basic C#
using System;
//for lists and collections
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

//for our basic graphics
using System.Drawing;
using System.Drawing.Text;

//for our dektop windows forms we can use
using System.Windows.Forms;

//This is our namespace for this project
namespace MS539_Landrau_14May26_Space_Cowboys_and_Alien_Thugs_RPG
{
    public partial class FrmStart : Form
    {
        //create our variables to hold our data
        //inside our class we want to create the properties aka variables to track our players values

        //int of health
        int playerHealth = 100;

        //int of players rupees aka cash aka
        int spaceCredits = 100;

        //This is our form construction method that runs once automagically when the form starts.

        public FrmStart()
        {
            //START PHASE II.
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            // call the function we made to update health and credits of our user
            UpdateStats();

            //this will not show until it runs

            //Now lets set the first location of our dropdown locations
            cmbLocations.Items.Add("Space Station");

            //lets add another location our user can go to
            cmbLocations.Items.Add("Mars Luxury Grand Resort");

            //lets add another location our user can go to
            cmbLocations.Items.Add("Mars Casino Floor");

            //lets add another location our user can go to
            cmbLocations.Items.Add("Mars Luxury Grand Resort Pool and Outdoor Lounge");

            //now lets make our combobox select a default location so its not empty
            cmbLocations.SelectedIndex = 0;

            //now lets let our user what is going on in our sim
            lblStory.Text = "Welcome to Your Great Vacation Destination!! Please Choose a Destination on Mars to Visit!!";


        }

        //create a method that will update the stats
        private void UpdateStats()
        {
            //This updates stuff on our GUI for us
            //This is taking our label controls called lblStats and setting its text property
            lblStats.Text = "Health: " + playerHealth.ToString() + "| Credits: " + spaceCredits.ToString();

        }
        // this handles the change of items in our combo box when our user changes to a new value
        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lets check values
            if (cmbLocations.SelectedIndex.ToString() == "Space Station")
            {
                //change background image to users newly selected location
                this.BackgroundImage = Properties.Resources.Luxury_Mars_Resort_Landing_Page;

                //update story for user
                lblStory.Text = "You are now aboard the Space Station Awaiting tranfer to the Resort on the Surface";


                if (cmbLocations.SelectedIndex.ToString() == "Mars Luxury Grand Resort")
                {
                    //change background image to users newly selected location
                    this.BackgroundImage = Properties.Resources.Luxury_Mars_Resort;

                    //update story for user
                    lblStory.Text = "You are now at the Resort on the Surface";


                    if (cmbLocations.SelectedIndex.ToString() == "Mars Casino Floor")
                    {
                        //change background image to users newly selected location
                        this.BackgroundImage = Properties.Resources.Luxury_Resort_Vacationing;

                        //update story for user
                        lblStory.Text = "You are now at the vacation area outside the Mars Casino Floor";

                        if (cmbLocations.SelectedIndex.ToString() == "Mars Luxury Grand Resort Pool and Outdoor Lounge")
                        {
                            //change background image to users newly selected location
                            this.BackgroundImage = Properties.Resources.Mars_Security_Station;

                            //update story for user
                            lblStory.Text = "Security are oblivious, the gangsters are boarding their landing crafts";
                            this.BackgroundImage = Properties.Resources.Gangsters;

                            //update story for user
                            this.BackgroundImage = Properties.Resources.Mars_Cowboy_Ranch;
                            lblStory.Text = "The ranch hands see the Gangsters ship arriving and mobilize to help the resort!!";

                            //update story for user
                            this.BackgroundImage = Properties.Resources.Gangsters_Going_to_Mars;
                            lblStory.Text = "Security are oblivious, the gangsters are arriving";




                        }
                        else if (cmbLocations.SelectedIndex.ToString() == "Mars Luxury Grand Resort")
                        {
                            //change background image to users newly selected location
                            this.BackgroundImage = Properties.Resources.Luxury_Resort_Vacationing;


                            //update story for user
                            lblStory.Text = "You are now at the Resort on the Surface";


                            //change background image to users newly selected location
                            this.BackgroundImage = Properties.Resources.Luxury_Mars_Resort;

                            //update story for user
                            lblStory.Text = "You are now at the Resort Main area and able to spend credits at the casino";



                        }
                    }
                }
            }
        }

            



        

        private void btnExplore_Click(object sender, EventArgs e)
        {
            //lets use a random number generator to simulate a dice roll in the RPG
            Random chance = new Random();

            //lets generate a number between 1 and 10
            int eventRoll = chance.Next(1, 11);

            //check number
            if (eventRoll > 5)
            {
                //create positive experience in environment
                lblStory.Text = "you found an abandoned ship! you sell it for scrap and get 20 Space Credits!!";

                //Modify the amounts in users bank account
                spaceCredits = spaceCredits + 20;

                //Gangsters Board their Ship for Mars

            }
            else if (eventRoll <= 5)
            {
                // something negative happens! 
                lblStory.Text = "Space Gangsters arrive to the casino and start TROUBLE!!";
                this.BackgroundImage = Properties.Resources.Gangsters_Going_to_Mars;

                //This is a long process

















                this.BackgroundImage = Properties.Resources.Mars_Security_Station;


                //This is a long process


















                this.BackgroundImage = Properties.Resources.Mars_Cowboy_Ranch;


                this.BackgroundImage = Properties.Resources.Gangsters;

                //Gangsters Arriving


                //Shootout Initiates Between Cowboys from Nearby Ranch and Alien Gangsters
                lblStory.Text = "Space Gangsters Start Battle";
                this.BackgroundImage = Properties.Resources.Gunbattle_at_Resort;


                //Now it costs some of our users health!
                playerHealth = playerHealth - 20;

                UpdateStats();

                //The battle intensifies!!
                lblStory.Text = "The Battle Intensifies!!";
                this.BackgroundImage = Properties.Resources.Intense_Gunbattle_at_resort;

                //More health is depleted!
                lblStory.Text = "Health is getting dangerously low!!";
                this.BackgroundImage = Properties.Resources.Prisoners;

                playerHealth = playerHealth - 60;

                //Refresh
                UpdateStats();

                //Has health dropped too low?
                if (playerHealth <= 100) ;
                {
                    //Show messagebox if our player has expired
                    MessageBox.Show("Your vacation is over because you have been robbed and have been enslaved by the Gangsters!!!");

                    //Close App
                    Application.Exit();
                }

                //

            }

        }

        private void lblStory_Click(object sender, EventArgs e)
        {

        }

        private void lblStats_Click(object sender, EventArgs e)
        {

        }
    }

}


















