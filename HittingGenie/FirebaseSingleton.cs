using Firebase.Auth;
using Firebase.Auth.Providers;
using System;

public class FirebaseSingleton
{
    private static readonly FirebaseSingleton instance = new();

    private FirebaseAuthConfig config;

    private FirebaseAuthClient authClient;


    static FirebaseSingleton()
    {
    }

    private FirebaseSingleton()
    {
        config = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyBPytwQQfv4DfykCVfOFRjP0bizx_0_-k8",
            AuthDomain = "hitting-genie.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }
        };

        authClient = new FirebaseAuthClient(config);
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
}
