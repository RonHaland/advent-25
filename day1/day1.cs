//Right = Up
//Left = Down

var fileName = args.Length > 0 ? args[0] : "./demoInput.txt";

var content = File.ReadAllLines(fileName);

var position = 50;
var count = 0;

foreach (var rotation in content)
{
  var diff = rotation[0] switch
  {
    'L' => -int.Parse(rotation[1..]),
    'R' => int.Parse(rotation[1..]),
    _ => 0,
  };
  position = (100 + position + diff) % 100;
  if (position == 0) count++;
}
System.Console.WriteLine("--------- PART 1 --------");
System.Console.WriteLine(count);
