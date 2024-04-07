using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;


public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager( int score)
    {
        _score = score;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    //public void ListGoalName()
    //{
        
    //}

    public void ListGoalDetails()
    {
        

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are :");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("which type of Goal would you like to create? ");
        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.WriteLine("What is the name of your goal? "); 
            string shortName = Console.ReadLine();
            
            

            Console.WriteLine("What is the description? ");
            string description = Console.ReadLine();

            Console.WriteLine($"what is the amount of points associated with this goal");
            int points = int.Parse(Console.ReadLine());

           SimpleGoal sg = new SimpleGoal(shortName, description, points);
           sg.GetStringRepresentation();
            
        }            

        else if (goalType == "2")
        {
            Console.WriteLine("What is the name of your goal? "); 
            string shortName = Console.ReadLine();

            Console.WriteLine("What is the description? ");
            string description = Console.ReadLine();

            Console.WriteLine($"what is the amount of points associated with this goal");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eg = new EternalGoal(shortName, description, points);
            eg.GetStringRepresentation();

        }

        else if (goalType == "3")
        {
            Console.WriteLine("What is the name of your goal? "); 
            string shortName = Console.ReadLine();

            Console.WriteLine("What is the description? ");
            string description = Console.ReadLine();

            Console.WriteLine($"what is the amount of points associated with this goal");
            int points = int.Parse(Console.ReadLine());

            Console.WriteLine($"How many times does this goal need to ba accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine($"What is the bonus for acomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());

            //ChecklistGoal cg = new ChecklistGoal(shortName, description, points);
            //cg.GetStringRepresentation();
        }

        else 
        {
            Console.WriteLine("invalid input");
        }



    }
    

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}