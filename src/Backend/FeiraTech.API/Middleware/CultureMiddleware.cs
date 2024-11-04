using System.Globalization;


namespace FeiraTech.API.Middleware
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
    public async Task Invoke(HttpContext context)
    {
        //Na linha abaixo, é possível obter a cultura do request
        var requestCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

        //Na linha abaixo, é possível obter todas as culturas suportadas pelo .NET
        var suportedCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

        //Na linha abaixo, é possível definir a cultura do request, caso a cultura da requisição não seja suportada
        var cultureInfo = new CultureInfo("pt-BR");
        
        //Verifica se a cultura da requesição é suportada e se não é nula ou vazia
        if (!string.IsNullOrWhiteSpace(requestCulture) 
            && suportedCultures.Any(c => c.Name.Equals(requestCulture)))
        {
            //Se a cultura da requisição for suportada, define a cultura do request
            cultureInfo = new CultureInfo(requestCulture);
        }

        //Define a cultura do request
        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        //Chama o próximo middleware
        await _next(context);
    }


    }
}