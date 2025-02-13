using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using BookDepo.ApiClient.Models;
using BookDepo.ApiClient.Models.ApiModels;

namespace BookDepo.ApiClient
{    
    public class BookDepoApiClientService
    {
        private readonly HttpClient _httpClient;

        public BookDepoApiClientService(ApiClientOptions apiClientOptions)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(apiClientOptions.ApiBaseAddress);
        }

        //gets all available books
        public async Task<List<Books>?> GetBooks()
        {
            return await _httpClient.GetFromJsonAsync<List<Books>?>("/api/Books");
        } 

        //get a book by id
        public async Task<Books?> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Books?>($"/api/Books/{id}");
        }

        //save a book
        public async Task SaveBook(Books book)
        {
            await _httpClient.PostAsJsonAsync("/api/Books/", book);
        }

        //update an existing book
        public async Task UpdateBook(Books book)
        {
            await _httpClient.PutAsJsonAsync("/api/Books/", book);
        }

        //delete an exsisting book
        public async Task DeleteBook(int id)
        {
            await _httpClient.DeleteAsync($"/api/Books/{id}");
        }
     }
}
