using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;

public class FirebaseSingleton
{
    private static readonly FirebaseSingleton instance = new();

    private FirebaseAuthConfig authConfig;
    private FirebaseAuthClient authClient;
    private FirebaseClient firebaseClient;

    static FirebaseSingleton()
    {
    }

    private FirebaseSingleton()
    {
        // Configure Firebase Authentication
        authConfig = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyBPytwQQfv4DfykCVfOFRjP0bizx_0_-k8",
            AuthDomain = "hitting-genie.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }
        };

        authClient = new FirebaseAuthClient(authConfig);

        // Configure Firebase Realtime Database
        firebaseClient = new FirebaseClient("https://hitting-genie-default-rtdb.firebaseio.com");
    }

    public static FirebaseSingleton Instance
    {
        get
        {
            return instance;
        }
    }

    public FirebaseAuthClient AuthClient
    {
        get
        {
            return authClient;
        }
    }

    public FirebaseClient FirebaseClient
    {
        get
        {
            return firebaseClient;
        }
    }
}
