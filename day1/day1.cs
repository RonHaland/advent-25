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
System.Console.WriteLine("-------------------------");



position = 50;
count = 0;

foreach (var rotation in content)
{
  var diff = rotation[0] switch
  {
    'L' => -int.Parse(rotation[1..]),
    'R' => int.Parse(rotation[1..]),
    _ => 0,
  };

  var fullRotations = Math.Abs(diff / 100);
  count += fullRotations;

  diff = diff > 0 ? //remove extra rotations so we dont cross the 0 mark an extra time
    diff - (fullRotations * 100) :
    diff + (fullRotations * 100);

  var targetPos = position + diff;

  if (position != 0 && (targetPos > 100 || targetPos < 0))
  { count++; }

  position = (100 + position + diff) % 100;
  if (position == 0) count++;

}
System.Console.WriteLine("--------- PART 2 --------");
System.Console.WriteLine(count);
System.Console.WriteLine("-------------------------");
