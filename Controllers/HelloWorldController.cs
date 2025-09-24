using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloWorldMVC.Controllers;

public class HelloWorldController : Controller
{
  //
  // GET: /HelloWorld/
  public static Index()
  {
    return "This is my default action...";
  }
  //
  // GET: /HelloWorld/Welcome/
  public static Welcome()
  {
    return "This is the Welcome action method...";
  }
}
