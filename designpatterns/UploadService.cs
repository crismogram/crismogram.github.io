// Sample Singleton Class for Upload Service, Threadsafe

sealed class UploadService{
    public UploadService(){}
    public int Id { get; private set; }
    private static readonly object _lock = new object();
    private static UploadService _instance;

    public static UploadService GetInstance(int id){
        if(_instance == null){
            lock(_lock){
                if(_instance == null){
                    _instance = new UploadService();
                    _instance.Id = id;
                }
            }
        }
        return _instance;
    }
}