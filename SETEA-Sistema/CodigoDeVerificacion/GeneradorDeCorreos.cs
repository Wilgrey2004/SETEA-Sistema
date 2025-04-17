using SETEA_Sistema.Entidades;
using SETEA_Sistema.Modelodb;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EmisorDeCorreosDeVerificacion
{
        internal class EmisorReceptorGmail
        {


                public int Enviar( string Emisor_, string ContraseñaEmisor_, string Receptor_ ) {
                        int codigo = new Random().Next(100000, 1000000);

                        string cuerpoHtml = $@"
                        <html>
                                <body style='font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px;'>
                                <div style='max-width: 600px; margin: auto; background: white; border-radius: 8px; padding: 20px; border: 1px solid #ddd;'>
                                        <h2 style='color: #333;'>Código de Verificación</h2>
                                        <p>Gracias por registrarte. Tu código de verificación es:</p>
                                        <p style='font-size: 24px; font-weight: bold; color: #007BFF;'>{codigo}</p>
                                        <p>Por favor, ingrésalo para continuar con el proceso.</p>
                                        <p style='font-size: 12px; color: #888;'>Este código es válido por unos minutos.</p>
                                </div>
                                </body>
                        </html>";

                        try
                        {
                                var mensaje = new MailMessage {
                                        From = new MailAddress(Emisor_),
                                        Subject = "Correo de verificación",
                                        SubjectEncoding = Encoding.UTF8,
                                        Body = cuerpoHtml,
                                        BodyEncoding = Encoding.UTF8,
                                        IsBodyHtml = true
                                };
                                mensaje.To.Add(Receptor_);

                                var smtp = new SmtpClient("smtp.gmail.com", 587) {
                                        Credentials = new NetworkCredential(Emisor_, ContraseñaEmisor_),
                                        EnableSsl = true
                                };

                                smtp.Send(mensaje);
                                return codigo;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Hubo un error al enviar el correo.\n" + ex.Message,
                                    "Error al enviar correo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                return -1;
                        }
                }

                internal void EnviarInformacionDeLaReparacion( string Emisor_, string ContraseñaEmisor_, ReparacionesRPShowModels RpShowModel, Estados_RP estados ) {
                        if(RpShowModel.Correo_Del_Cliente == null)
                        {
                                MessageBox.Show("El cliente no tiene un correo registrado, por lo que no se puede enviar la informacion de la reparacion.",
                                    "Error al enviar correo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                return;
                        }
                        string cuerpoHtml = $@"
                                <!DOCTYPE html>
                                <html lang='es'>
                                  <head>
                                    <meta charset='UTF-8' />
                                    <meta name='viewport' content='width=device-width, initial-scale=1.0' />
                                    <title>Estado de Reparación</title>
                                  </head>
                                  <body style='
                                    font-family: system-ui, -apple-system, BlinkMacSystemFont, Segoe UI,
                                    Roboto, Oxygen, Ubuntu, Cantarell, Open Sans, Helvetica Neue, sans-serif;
                                    background-color: #4e4c4c;
                                    padding: 20px;
                                  '>
                                    <div style='
                                      max-width: 600px;
                                      margin: auto;
                                      background: rgb(24, 36, 55);
                                      border-radius: 16px;
                                      padding: 20px;
                                      border: 1px solid #ddd;
                                      text-align: center;
                                    '>
                                      <h4 style='color: #fff9f9'>
                                        Su dispositivo
                                        <span style='font-weight: bold; color: #007bff'>
                                          {RpShowModel.Tipo_Dispositivo}/{RpShowModel.Marca_Dispositivo}
                                        </span>
                                      </h4>

                                      <p style='font-size: 16px; color: #ffffff'>
                                        El estado actual de su dispositivo es: 
                                        <span style='font-weight: bold; color: #007bff'>{estados.Estado}</span>
                                      </p>

                                      <p style='font-size: 16px; color: #ffffff'>
                                        <span style='color: #007bff'>{estados.Descripcion}</span>
                                      </p>

                                      <p style='color: white; font-size: 16px'>
                                        Costo estimado de la reparación: 
                                        <span style='font-weight: bold; color: #007bff'>
                                          {RpShowModel.Cobro_Reparacion} DOP
                                        </span>
                                      </p>

                                      <p style='font-size: 16px; color: #f6f6f6'>
                                        Diagnóstico actual:<br />
                                        <span style='color: rgb(158, 165, 247)'>{RpShowModel.Diagnostico_Inicial}</span>
                                      </p>

                                      <p style='font-size: 16px; color: #3873f1'>
                                        S.T.E.A - Donde te seteamos a nivel tecnológico
                                      </p>
                                    </div>
                                  </body>
                                </html>";


                        try
                        {
                                var mensaje = new MailMessage {
                                        From = new MailAddress(Emisor_),
                                        Subject = $"Estimado/da {RpShowModel.Nombre_Cliente}, el estado de su dispositivo {RpShowModel.Tipo_Dispositivo}/{RpShowModel.Marca_Dispositivo} ha cambiado a *{estados.Estado}*",
                                        SubjectEncoding = Encoding.UTF8,
                                        Body = cuerpoHtml,
                                        BodyEncoding = Encoding.UTF8,
                                        IsBodyHtml = true
                                };
                                mensaje.To.Add(RpShowModel.Correo_Del_Cliente);

                                var smtp = new SmtpClient("smtp.gmail.com", 587) {
                                        Credentials = new NetworkCredential(Emisor_, ContraseñaEmisor_),
                                        EnableSsl = true
                                };

                                smtp.Send(mensaje);

                        } catch (Exception ex)
                        {
                                MessageBox.Show("Hubo un error al enviar la informacion de la reparacion.\n" + ex.Message,
                                    "Error al enviar correo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                        }
                }
        }
}

