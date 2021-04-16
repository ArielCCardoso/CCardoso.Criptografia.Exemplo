# Criptografia Exemplo

Aplicação Console [.NET Core 3.1 LTS] que aplica métodos de criptografia e descriptografia com chave RSA PKCS#1.

### Setup

 - [ ✅ ] Path das chaves RSA

```cshap
string path = $@"{Directory.GetCurrentDirectory()}\..\..\..\";
```
> Lembre-se de alterar para o padrão da sua distro. [Windows, Linux, Mac]

 - [ ✅ ] Gerar chaves RSA
```bash
$ openssl genrsa -out private.pem 2048
$ openssl rsa -outform PEM -in private.pem -out public.pem -pubout -RSAPublicKey_out
$ sed -i '/---/d' private.pem
$ sed -i '/---/d' public.pem
```
> Usei 2048 bits apenas para a demo, mas recomendo um valor acima de 4096❗

Agora é só rodar!!!  🚀🚀🚀