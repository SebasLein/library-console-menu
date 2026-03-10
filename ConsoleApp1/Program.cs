using System;
using System.Collections.Generic;
class Program
{
    static List<string> books = new List<string>();
    static void Main()
    {
        ShowMainMenu();
    }

    static void ShowMainMenu()
{
    int opcion = 0;

    while (opcion != 6)
    {
        Console.WriteLine("\n===== SISTEMA DE BIBLIOTECA =====");
        Console.WriteLine("1. Libros");
        Console.WriteLine("2. Usuarios");
        Console.WriteLine("3. Prestamos");
        Console.WriteLine("4. Busquedas y reportes");
        Console.WriteLine("5. Guardar / Cargar datos");
        Console.WriteLine("6. Salir");

        Console.Write("Seleccione una opcion: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                ShowBooksMenu();
                break;

            case 2:
                ShowUsersMenu();
                break;

            case 3:
                ShowLoansMenu();
                break;

            case 4:
                Console.WriteLine("Entrando a busquedas y reportes...");
                break;

            case 5:
                Console.WriteLine("Entrando a guardar/cargar datos...");
                break;

            case 6:
                Console.WriteLine("Saliendo del sistema...");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
static void ShowBooksMenu()
{
    int opcion = 0;

    while (opcion != 6)
    {
        Console.WriteLine("\n===== MENU LIBROS =====");
        Console.WriteLine("1. Registrar libro");
        Console.WriteLine("2. Listar libros");
        Console.WriteLine("3. Ver detalle de libro");
        Console.WriteLine("4. Actualizar libro");
        Console.WriteLine("5. Eliminar libro");
        Console.WriteLine("6. Volver al menu principal");

        Console.Write("Seleccione una opcion: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                RegisterBook();
                break;

            case 2:
                ListBooksMenu();
                break;

            case 3:
                ViewBookDetail();
                break;

            case 4:
                UpdateBookMenu();
                break;

            case 5:
                DeleteBook();
                break;

            case 6:
                Console.WriteLine("Volviendo al menu principal...");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
static void ListBooksMenu()
{
    int opcion = 0;

    while (opcion != 4)
    {
        Console.WriteLine("\n===== LISTAR LIBROS =====");
        Console.WriteLine("1. Listar todos");
        Console.WriteLine("2. Listar disponibles");
        Console.WriteLine("3. Listar prestados");
        Console.WriteLine("4. Volver");

        Console.Write("Seleccione una opcion: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                ListBooksAll();
                break;

            case 2:
                ListBooksAvailable();
                break;

            case 3:
                ListBooksBorrowed();
                break;

            case 4:
                Console.WriteLine("Volviendo...");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
static void ListBooksAll()
{
    Console.WriteLine("\n===== TODOS LOS LIBROS =====");

    if (books.Count == 0)
    {
        Console.WriteLine("No hay libros registrados.");
        return;
    }

    int numero = 1;

    foreach (string book in books)
    {
        Console.WriteLine(numero + ". " + book);
        numero++;
    }
}

static void ListBooksAvailable()
{
    Console.WriteLine("Listando libros disponibles...");
}

static void ListBooksBorrowed()
{
    Console.WriteLine("Listando libros prestados...");
}
static void UpdateBookMenu()
{
    int opcion = 0;

    while (opcion != 4)
    {
        Console.WriteLine("\n===== ACTUALIZAR LIBRO =====");
        Console.WriteLine("1. Editar titulo");
        Console.WriteLine("2. Editar autor");
        Console.WriteLine("3. Editar año / categoria");
        Console.WriteLine("4. Volver");

        Console.Write("Seleccione una opcion: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                EditBookTitle();
                break;

            case 2:
                EditBookAuthor();
                break;

            case 3:
                EditBookYearCategory();
                break;

            case 4:
                Console.WriteLine("Volviendo...");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
static void EditBookTitle()
{
    Console.WriteLine("\n===== EDITAR TITULO =====");

    if (books.Count == 0)
    {
        Console.WriteLine("No hay libros registrados.");
        return;
    }

    int numero = 1;

    foreach (string book in books)
    {
        Console.WriteLine(numero + ". " + book);
        numero++;
    }

    Console.Write("\nSeleccione el numero del libro: ");
    int seleccion = Convert.ToInt32(Console.ReadLine());

    if (seleccion < 1 || seleccion > books.Count)
    {
        Console.WriteLine("Numero invalido.");
        return;
    }

    Console.Write("Ingrese el nuevo titulo: ");
    string nuevoTitulo = Console.ReadLine();

    books[seleccion - 1] = nuevoTitulo;

    Console.WriteLine("Titulo actualizado correctamente.");
}

static void EditBookAuthor()
{
    Console.WriteLine("\n===== EDITAR AUTOR =====");

    if (books.Count == 0)
    {
        Console.WriteLine("No hay libros registrados.");
        return;
    }

    int numero = 1;

    foreach (string book in books)
    {
        Console.WriteLine(numero + ". " + book);
        numero++;
    }

    Console.Write("\nSeleccione el numero del libro: ");
    int seleccion = Convert.ToInt32(Console.ReadLine());

    if (seleccion < 1 || seleccion > books.Count)
    {
        Console.WriteLine("Numero invalido.");
        return;
    }

    Console.Write("Ingrese el nuevo autor: ");
    string nuevoAutor = Console.ReadLine();

    books[seleccion - 1] = books[seleccion - 1] + " - " + nuevoAutor;

    Console.WriteLine("Autor actualizado correctamente.");
}

static void EditBookYearCategory()
{
    Console.WriteLine("Editando año o categoria del libro...");
}
static void RegisterBook()
{
    Console.Write("Ingrese el titulo del libro: ");
    string titulo = Console.ReadLine();

    books.Add(titulo);

    Console.WriteLine("Libro registrado correctamente.");
}
static void ViewBookDetail()
{
    Console.WriteLine("\n===== DETALLE DE LIBRO =====");

    if (books.Count == 0)
    {
        Console.WriteLine("No hay libros registrados.");
        return;
    }

    // Mostrar la lista para que el usuario elija
    int numero = 1;
    foreach (string book in books)
    {
        Console.WriteLine(numero + ". " + book);
        numero++;
    }

    Console.Write("\nSeleccione el numero del libro: ");
    int seleccion = Convert.ToInt32(Console.ReadLine());

    if (seleccion < 1 || seleccion > books.Count)
    {
        Console.WriteLine("Numero invalido.");
        return;
    }

    string selectedBook = books[seleccion - 1];

    Console.WriteLine("\n===== INFORMACION DEL LIBRO =====");
    Console.WriteLine("Titulo: " + selectedBook);
}
static void DeleteBook()
{
    Console.WriteLine("\n===== ELIMINAR LIBRO =====");

    if (books.Count == 0)
    {
        Console.WriteLine("No hay libros registrados.");
        return;
    }

    int numero = 1;

    foreach (string book in books)
    {
        Console.WriteLine(numero + ". " + book);
        numero++;
    }

    Console.Write("\nSeleccione el numero del libro a eliminar: ");
    int seleccion = Convert.ToInt32(Console.ReadLine());

    if (seleccion < 1 || seleccion > books.Count)
    {
        Console.WriteLine("Numero invalido.");
        return;
    }

    books.RemoveAt(seleccion - 1);

    Console.WriteLine("Libro eliminado correctamente.");
}
static void ShowUsersMenu()
{
    int opcion = 0;

    while (opcion != 6)
    {
        Console.WriteLine("\n===== MENU USUARIOS =====");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Listar usuarios");
        Console.WriteLine("3. Ver detalle de usuario");
        Console.WriteLine("4. Actualizar usuario");
        Console.WriteLine("5. Eliminar usuario");
        Console.WriteLine("6. Volver");

        Console.Write("Seleccione una opcion: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                RegisterUser();
                break;

            case 2:
                ListUsers();
                break;

            case 3:
                ViewUserDetail();
                break;

            case 4:
                UpdateUserMenu();
                break;

            case 5:
                DeleteUser();
                break;

            case 6:
                Console.WriteLine("Volviendo...");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
static void ShowLoansMenu()
{
    int opcion = 0;

    while (opcion != 5)
    {
        Console.WriteLine("\n===== MENU PRESTAMOS =====");
        Console.WriteLine("1. Crear prestamo");
        Console.WriteLine("2. Listar prestamos");
        Console.WriteLine("3. Registrar devolucion");
        Console.WriteLine("4. Eliminar prestamo");
        Console.WriteLine("5. Volver");

        Console.Write("Seleccione una opcion: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                CreateLoan();
                break;

            case 2:
                ListLoansMenu();
                break;

            case 3:
                RegisterReturn();
                break;

            case 4:
                DeleteLoan();
                break;

            case 5:
                Console.WriteLine("Volviendo...");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
static void CreateLoan()
{
    Console.WriteLine("Creando prestamo...");
}

static void ListLoansMenu()
{
    Console.WriteLine("Listando prestamos...");
}

static void RegisterReturn()
{
    Console.WriteLine("Registrando devolucion...");
}

static void DeleteLoan()
{
    Console.WriteLine("Eliminando prestamo...");
}
}