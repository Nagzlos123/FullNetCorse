using Composition_Inheritance;

var butterfly = new Butterfly(new FlyingAnimal());
Console.WriteLine(butterfly);
var lion = new Lion(new LandAnimal());
Console.WriteLine(lion);
