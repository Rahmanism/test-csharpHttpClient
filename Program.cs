using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

var urls = new string[] {
  "http://webcode.me", 
  "http://example.com",
  "http://httpbin.org",
  "https://ifconfig.me",
  "http://termbin.com",
  "https://github.com"
};

var rx = new Regex(
  @"<title>\s*(.+?)\s*</title>",
  RegexOptions.Compiled
);

using var client = new HttpClient();

List<Task<string>> tasks = new();

            Console.WriteLine("Hello World!");

