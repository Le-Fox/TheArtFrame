using ArtFrame.Models;

namespace ArtFrame.Repository
{
    public interface IObjectRepository
    {
        Task<ObjectsModel> getObjects();
        Task<ObjectResponseModel> getObject(int ObjectID);
        Task<List<ObjectResponseModel>> getObjectList(List<int> ObjectID);

        Task<List<int>> getValidObject(ObjectsModel objects);

    }
}
