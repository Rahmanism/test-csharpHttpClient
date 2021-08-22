/*
Learn HttpClient
https://zetcode.com/csharp/httpclient/
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

var urls = new string[] {
  "http://webcode.me", 
  "http://example.com",
  "http://httpbin.org"
};

Regex rx = new(
  @"<title>\s*(.+?)\s*</title>",
  RegexOptions.Compiled
);

using HttpClient client = new();

List<Task<string>> tasks = new();
foreach (var url in urls)
{
    tasks.Add(client.GetStringAsync(url));
}

Task.WaitAll(tasks.ToArray());

List<string> data = new();
foreach (var task in tasks)
{
    data.Add(await task);
}

foreach (var content in data)
{
    var matches = rx.Matches(content);
    foreach (var match in matches)
    {
        Console.WriteLine(match);
    }
}
