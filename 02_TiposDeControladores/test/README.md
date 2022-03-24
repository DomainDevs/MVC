#Cada controlador tiene métodos de distinto tipo
1. ActionResult / IActionResult: Es la opción más genérica que existe, dependiendo de que tipo de
 contenido que queramos mostrar lo usamos (Puede devolver texto plano, vista, formato json).
2. ViewResult: Represents HTMLand markup
3. EmptyResult - Represent not result.
4. RedirectResult - Represent a redirection to new URL.
5. JsonResult - Represent a Javascript Object Notation result that can be used in an AJAX application
6. JavaScriptResult - Represents a Javascript script.
7. ContentResult - Represents a text Result.
8. FileContentResult - Represents Downloadable file (with a the binary content)
9. FilePathResult - Represents Downloadable file (with a path)
10. FileStreamResult - Represents Downloadable file (with a file stream)

