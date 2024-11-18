// See https://aka.ms/new-console-template for more information

using cookies_cookBook;
using cookies_cookBook.IngredientsNameSpace;




CookieRecipes newcookies = new CookieRecipes();

newcookies.AddList(new WheatFlour());
newcookies.AddList(new CoconutFlour());

newcookies.ListAll();