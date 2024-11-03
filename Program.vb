Imports BCrypt.Net

Module Program
    Sub Main()
        ' Senha que você deseja hash para o teste
        Dim senha As String = "teste"

        ' Gerar o hash da senha usando BCrypt
        Dim hashSenha As String = BCrypt.Net.BCrypt.HashPassword(senha)

        ' Exibir o hash da senha
        Console.WriteLine("Hash da Senha: " & hashSenha)
        Console.ReadLine()
    End Sub
End Module
