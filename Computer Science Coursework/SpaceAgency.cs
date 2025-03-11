namespace Computer_Science_Coursework
{
    internal class SpaceAgency
    {
        //Fields of SpaceAgency class:
        public string name;
        private double bankBalance;
        private Queue<Mission> missions = new Queue<Mission>();
        private Mission activeMission;

        //Public accessors for private fields:
        public Mission ActiveMission
        {
            get { return activeMission; }
        }

        public double BankBalance
        {
            get { return bankBalance; }
        }

        public SpaceAgency()
        {
            this.bankBalance = 1000000000;
            this.name = "Untitled Space Agency";
            InitializeMissions();
            activeMission = missions.Dequeue();
        }
        public void NextMission() //Method to progress to the next mission in the queue
        {
            missions.Enqueue(activeMission);
            activeMission = missions.Dequeue();
        }
        public void MissionSuccess() //Method to reward the player for completing a mission
        {
            bankBalance = bankBalance + activeMission.Reward;
            NextMission();
        }
        private void InitializeMissions()
        { //Method to add missions to the mission queue
            missions.Enqueue(new Mission("Suborbital Test Flight", "Launch an unmanned rocket to suborbital space.", 100000, false, false, 100000000));
            missions.Enqueue(new Mission("Low Mars Orbit Satellite", "Deploy a unmanned satellite into low Mars orbit.", 300000, true, false, 500000000));
            missions.Enqueue(new Mission("Low Mars Orbit Manned Mission", "Send astronauts into low Mars orbit for scientific research.", 600000, true, true, 1000000000));
            missions.Enqueue(new Mission("High Mars Orbit Satellite Deployment", "Deploy a unmanned satellite into high Mars orbit for deep space observation.", 1500000000, true, false, 750000));    
        }
        public void RemoveFunds(double transactionSize)
        { //Method to remove funds from the bank balance for launching rockets
            bankBalance = bankBalance - transactionSize;
        }


    }
}
