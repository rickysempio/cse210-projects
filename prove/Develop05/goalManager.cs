using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.IO;



public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

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
        
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
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
            string  shortName = Console.ReadLine();

            Console.WriteLine("What is the description? ");
            string description = Console.ReadLine();

            Console.WriteLine($"what is the amount of points associated with this goal");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal sg = new SimpleGoal(shortName, description, points);
            sg.GetStringRepresentation();
            _goals.Add(sg);
            
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
            _goals.Add(eg);

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

            ChecklistGoal cg = new ChecklistGoal(shortName, description, points, bonus);
            cg.GetStringRepresentation();
            _goals.Add(cg);
        }

        else 
        {
            Console.WriteLine("invalid input");
        }



    }
    

    public void RecordEvent()
    {

    }

    public void SaveGoalsToFile(string file)
    {
        using(StreamWriter writer = new(file))
        {
        foreach (Goal goal in _goals)
            writer.WriteLine($"{goal.GetShortName}|{goal.GetDescription}|{goal.GetPoints}");
        }
    }


    public void LoadGoals()
    {
        //_goals.Clear();
        //string[] lines = File.ReadAllLines(file);

        //foreach (String line in lines)
        //{
            //string [] parts = line.Split("|");
            
     
        //}
    }
}   

