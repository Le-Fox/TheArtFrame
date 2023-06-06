using ArtFrame.Models;
using Newtonsoft.Json;
using System;

namespace ArtFrame.Repository
{
    public class ObjectRepository :IObjectRepository
    {
        public async Task<ObjectsModel> getObjects()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://collectionapi.metmuseum.org/public/collection/v1/objects"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    
                    ObjectsModel model = JsonConvert.DeserializeObject<ObjectsModel>(apiResponse);
                    
                    return model;
                }
            }
           
        }

        public async Task<ObjectResponseModel> getObject(int ObjectID)
        {

            ObjectResponseModel model;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://collectionapi.metmuseum.org/public/collection/v1/objects/" + ObjectID))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    model = JsonConvert.DeserializeObject<ObjectResponseModel>(apiResponse);

                }
            }

            return model;
            
        }

        public async Task<List<int>> getValidObject(ObjectsModel objects)
        {
          
           List <int> validObjects = new List<int>();
           
                foreach (int obj in objects.ObjectIDs)
                {
                    int i = obj;
                    if ( await objectValidator(obj) == true)
                    {
                        validObjects.Add(i);
                    }   
              };
            return validObjects;
        }

        public async Task<bool> objectValidator(int objectId)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://collectionapi.metmuseum.org/public/collection/v1/objects/"+objectId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    ObjectResponseModel model = JsonConvert.DeserializeObject<ObjectResponseModel>(apiResponse);

                    if(model.isPublicDomain == true )
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        public async Task<List<ObjectResponseModel>> getObjectList(List<int> ObjectID)
        {
            List<ObjectResponseModel> Objects = new List<ObjectResponseModel>();
            foreach (int obj in ObjectID)
            {
                Objects.Add( await getObject(obj));
            };

            return Objects;

        }
    }
}
