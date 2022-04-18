# Hämta alla personer i systemet.
För att hämta alla användare i Postman så väljer jag Get och /Users.

# Hämta alla intressen som är kopplade till en specifik person och hämta alla länkar som är kopplade till en specifik person.
För att hämta en användare tillsammans med alla deras hobbyer och länkar så väljer jag Get och /Users/2, siffran motsvarar ju då en användares id nummer.

# Koppla en person till ett nytt intresse.
För att koppla en användare till en ny hobby så behöver man använda PUT, Body, raw, JSON och /Websites/siffra, sen så behöver jag ändra "websiteID" till vilken länk jag vill koppa till, ändra "hobbyID" till vilken hobby länken ska tillhöra och sen ändra "userID" till vilken användare det är som ska få den nya hobbyn och länken.

# Lägga in nya länkar för en specifik person och ett specifikt intresse.
För att lägga in nya länkar för en specifik användare och hobby så behöver man använda POST, Body, raw, JSON och /Websites, sen så lägger man till i "websiteLink" vilken URL den nya länken har, sen i "hobbyID" så skriver man vilken hobby länken ska tillhöra och efter det så ska man i "userID" skriva vilken användare det är som ska få den nya länken.
