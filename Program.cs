/*
    Almacenar el nombre de productos de tecnologia, cada prod está identificado con un ID
*/

Dictionary<int, string> products = new Dictionary<int, string>();
string opc = "";

while (opc != "5")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("1. Agregar producto 2.Eliminar producto 3.Mostrar producto 4.Mostrar Productos");
    Console.ForegroundColor = ConsoleColor.Green;
    opc = Console.ReadLine();
    
    switch (opc)
    {
        case "1":
            Console.WriteLine("Dame el nombre del producto: ");
            string name = Console.ReadLine();
            products.Add(products.Count, name);
            ShowProducts(products);
            break;
        
        case "2":
            Console.WriteLine("Dame el ID del producto: ");
            string idProd = Console.ReadLine();
            int id = int.Parse(idProd);
            products.Remove(id);
            ShowProducts(products);
            break;
        
        case "3":
            Console.WriteLine("Dame el nombre del producto: ");
            string prodName = Console.ReadLine();
            if (products.ContainsValue(prodName))
            {
                foreach (var prod in products)
                {
                    if (prod.Value == prodName)
                    {
                        Console.WriteLine($"Clave: {prod.Key}, Nombre: {prod.Value}");
                    }
                }
            }

            break;
        case "4":
            ShowProducts(products);
            break;
    }
    
}

void ShowProducts(Dictionary<int, string> prods)
{
    Console.ForegroundColor = ConsoleColor.Red;
    foreach (var prod in prods)
    {
        Console.WriteLine($"Clave: {prod.Key}, Nombre: {prod.Value}");
    }      
}