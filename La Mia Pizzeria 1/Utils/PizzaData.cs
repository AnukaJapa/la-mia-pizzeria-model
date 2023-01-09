using La_Mia_Pizzeria_1.Models;

namespace La_Mia_Pizzeria_1.Utils;
public static class PizzaData
{
    private static List<Pizza> pizzas;

    public static List<Pizza> GetPizzas()
    {
        string[] titleArray = {"Pizza con i peperoni e pomodorini", "Pizza con le olive e funghi", "Pizza con i pomodorini sechi e bufala", "pizza strana", "Pizza con i bacon e wurstel", "pizza con la rucola", "pinsa","pizza misteriosa", "pizza con il prosciutto crudo","pizza con la mozzarella sopra","pizza con la marmellata", "pizza gialla" };
        string[] imagesUrlArray = { "https://cdn.pixabay.com/photo/2017/02/15/10/57/pizza-2068272_960_720.jpg", "https://cdn.pixabay.com/photo/2016/11/29/13/02/cheese-1869708_960_720.jpg", "https://cdn.pixabay.com/photo/2020/06/08/16/49/pizza-5275191_960_720.jpg", "https://cdn.pixabay.com/photo/2018/04/11/03/13/food-3309418_960_720.jpg", "https://cdn.pixabay.com/photo/2018/12/12/13/04/pizza-3870780_960_720.jpg", "https://cdn.pixabay.com/photo/2017/01/22/19/12/pizza-2000600_960_720.jpg", "https://images.pexels.com/photos/11351373/pexels-photo-11351373.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "https://images.pexels.com/photos/1552635/pexels-photo-1552635.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "https://images.pexels.com/photos/10875206/pexels-photo-10875206.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "https://images.pexels.com/photos/4562970/pexels-photo-4562970.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "https://images.pexels.com/photos/14030948/pexels-photo-14030948.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "https://images.pexels.com/photos/6605220/pexels-photo-6605220.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" };
        
        if(pizzas != null)
        {
            return pizzas;
        }
        pizzas = new List<Pizza>();

        for (int i = 0; i < titleArray.Length; i++){
            Pizza pizzaPageContent = new Pizza(i, titleArray[i], "\"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of", imagesUrlArray[i]);
            pizzas.Add(pizzaPageContent);
        }

        return pizzas;
    }

}
