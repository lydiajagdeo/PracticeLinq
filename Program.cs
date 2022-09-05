

List<string> makeUpBrands = new List<string>()
{
    "Mac",
    "UrbanDecay",
    "Fenty",
    "Makeup Forever",
    "NYX",
    "Laura Mercier"

};

makeUpBrands.OrderBy(brand => brand.Length).ToList().ForEach(brand => Console.WriteLine(brand));

