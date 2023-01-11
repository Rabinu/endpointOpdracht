using System.Security.Cryptography;
using System.Text;

namespace HashEndpoint.Domain;

class Hash
{
    private string value;

    // Ik probeer dat Hash niet aangeroepen kan worden door new Hash() en alleen aangemaakt kan worden met GenerateHash
    private Hash()
    {
        // Ik kreeg een waarschuwing:
        // Non-nullable field 'value' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [HashEndpoint]
        // Weet niet of dit de correct methode is door hier value een empty string te maken.
        this.value = string.Empty;
    }

    public string Value
    {
        get { return this.value; }
        set { this.value = value; }
    }

    // Simpele hash zonder salt
    public static Hash GenerateHash(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2"));
            }
            return new Hash { Value = builder.ToString() };
        }
    }
}
