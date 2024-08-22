using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class MoviesController : Controller
{
	// GET: /Movies
	public string Index()
	{
		return "You're at home";
	}

	public string Welcome(string name)
	{
		return HtmlEncoder.Default.Encode($"Movie selected to watch {name}");
	}
}
