var agent = PINQAgentBudget(1.0);
var data = new PINQueryable<string>(rawdata, agent);

var users = data.Select(line => line.Split(','))
                .Where(fields => fields[2] <= aWeekAgo)
                .GroupBy(fields => fields[0]);

Console.WriteLine("Unique visitors last week: " + users.NoisyCount(0.1));