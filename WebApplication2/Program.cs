var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "CodingHub/{controller=Home}/{action=Index}/{id?}");

app.Run();


#region SummaryOftaghelpers
/*
 * special attribure provided by asp.net core 
 * similar to HTML helpers of asp.net 05
 * use to generate server side html code 
 * namespace:Microsoft.AspNetCore.Mvc.TagHelpers
 * @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
 */
#endregion

#region HyperlinkTagHelper
/*
 * inside <a> tag just set two attributr asp-controller and asp-action  asp-route-id(optional)
 * and this will work as ordinary <a> of HTML
 * What is benifite?
 * so benifit is if we want our company name in pattern like CodingHub/.. so this will obtain by HyperlinkTAgHelper
 */
#endregion

#region ImageTagHelper
/*
 * when we first time upload our image on web browser then that time image downloads via local server i-e PC
 * but after 1 time this image recovers via cache memory of our browser
 * so when we change our image name and try access image so that image will be access by cache memory 
 * use asp-append-version set the value to true
 */
#endregion

