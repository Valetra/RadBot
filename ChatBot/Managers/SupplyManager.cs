﻿using Contracts;
using Models;
using Newtonsoft.Json;

namespace ChatBot.Managers;

public class SupplyManager
{
    public static async Task<List<ISupply>> GetSuppliesFromAPI(ControllerManager controllerManager)
    {
        HttpClient httpClient = new HttpClient();

        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, controllerManager.GetSupplyURL());

        using HttpResponseMessage response = await httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Supply>>(responseString)?.ToList<ISupply>() ?? new();
        }
        else
        {
            return new();
        }
    }
}
