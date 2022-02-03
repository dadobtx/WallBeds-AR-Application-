
using System.Collections;
using System.Collections.Generic;
using Firebase;
using Firebase.Auth;
using Google;
using UnityEngine;

public class GoogleSignInFirebase : MonoBehaviour
{
    // Start is called before the first frame update

    private FirebaseAuth auth;
    void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoogleSignIn()
    {
        Credential credential = GoogleAuthProvider.GetCredential("sdfsfdf", null);
        auth.SignInWithCredentialAsync(credential).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithCredentialAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithCredentialAsync encountered an error: " + task.Exception);
                return;
            }

            FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
        });
    }
}
