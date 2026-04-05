# AgAuth

> **✨ Make sure to follow instructions below to host this identity server as a public web app.**

This identity server is https enabled one and you need forward your public requests to a secured url

- Save **Ngrok** into a spearate directory 
- You're running your identity server on this local url **[https://localhost:5001]**
- Use command **"ngrok http --host-header=rewrite https://localhost:5001"** to run **ngrok**. It'll look like follwing.
<img width="1174" height="460" alt="image" src="https://github.com/user-attachments/assets/73849d69-0457-4d75-89c4-6f10acadb19e" />

- Copy the highlited url and paste in in the **PublicOrigin** in the **appsettings.json** file and you're set.
<img width="872" height="444" alt="image" src="https://github.com/user-attachments/assets/ff07fb82-ef9e-4d87-999e-a3faddfee64c" />

> **✨ Follow instructions of the Readme of mobile app to set configurations.
>
> # Test Users
-admin/1234
-bob/bob
-alice/alice
