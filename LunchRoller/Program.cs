Console.WriteLine("來決定今天的午餐吧......\n");

var lunch = new List<string>();

var streamReader = new StreamReader(".\\LunchMenu.txt");
var content = streamReader.ReadToEnd();
if (string.IsNullOrEmpty(content))
{
    Console.WriteLine("\n選單中無內容可用。");
}

var lunchMenu = content.Split(',');
foreach (var item in lunchMenu)
{
    lunch.Add(item);
}

var target = new Random().Next(0, lunch.Count - 1);

Console.WriteLine($"\n今日午餐：{lunch[target]}\n");

Console.ReadKey();
