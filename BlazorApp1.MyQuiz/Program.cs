using BlazorApp1.MyQuiz;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();


/*
 * Who won the football club GAA final
 * and hurling club all ireland finals
 * Rugby Question
 * Which Premier League team has scored the most goals
 * F1 question
 * Which of these fictional duos lives in Harlech Tower? (Mario and Luigi, Delboy and Rodney, Jeeves and Wooster, Tom and Jerry)
 * Which of these duos does not feature a human and a talking dog?  (Wallace and Gromit)
 * Which of these duos did not originate from a comic book?/originally came from a comic book?
 * 
 * Which of these actors have starred in the most movies together? (Dwayne Johnston and Kevin Hart, Chris Hemsworth and Tom Hiddleston, Jamie Lee Curtis and Lindsey Lohan, 
 * Chancellor of Germany in 1933
 * Which of these Irish historical figures came first?
 * In what year did the Industrial Revolution begin?
 * Which of these European dictators ruled the longest?
 * In what county was the historic Ballykinlar prison camp formerly located in? (Down, Offaly, Kerry, Mayo)
 * The River Shannon flows through the border areas of which of these counties (Tyrone and Derry, Longford and Roscommon, Kerry and Cork,  Waterford and Kilkenny)
*/

 
