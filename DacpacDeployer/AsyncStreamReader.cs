namespace DacpacDeployer;

public class AsyncStreamReader
{
#pragma warning disable CS8981 // Le nom de type contient uniquement des caractères ascii en minuscules. De tels noms peuvent devenir réservés pour la langue.
    public delegate void EventHandler<args>(object sender, string Data);
#pragma warning restore CS8981 // Le nom de type contient uniquement des caractères ascii en minuscules. De tels noms peuvent devenir réservés pour la langue.
    public event EventHandler<string> DataReceived = null!;

    protected readonly byte[] buffer = new byte[4096];
    private readonly StreamReader reader;

    public AsyncStreamReader(StreamReader readerToBypass)
    {
        reader = readerToBypass;
        Active = false;
    }

    public bool Active { get; private set; }


    public void Start()
    {
        if (!Active)
        {
            Active = true;
            BeginReadAsync();
        }
    }

    public void Stop()
    {
        Active = false;
    }

    protected void BeginReadAsync()
    {
        if (Active)
            reader.BaseStream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(ReadCallback), null);
    }

    private void ReadCallback(IAsyncResult asyncResult)
    {
        int bytesRead = reader.BaseStream.EndRead(asyncResult);

        string data = null!;
        if (bytesRead > 0)
            data = reader.CurrentEncoding.GetString(buffer, 0, bytesRead);
        else
            Active = false;

        DataReceived?.Invoke(this, data);

        BeginReadAsync();
    }
}
