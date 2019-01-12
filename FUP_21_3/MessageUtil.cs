using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FUP_21_3
{
    class MessageUtil
    {
        public static void Send(Stream writer, Message msg)
        {
            writer.Write(msg.GetBytes(), 0, msg.GetSize());
        }

        public static Message Receive(Stream reader)
        {
            int totalRecv = 0;
            int sizeToRead = 16;
            byte[] hBuffer = new byte[sizeToRead];

            while (sizeToRead > 0)
            {
                byte[] buffer = new byte[sizeToRead];
                int recv = reader.Read(buffer, 0, sizeToRead);
                if (recv == 0)
                    return null;

                buffer.CopyTo(hBuffer, totalRecv);
                totalRecv += recv;
                sizeToRead -= recv;
            }

            Header header = new Header(hBuffer);

            totalRecv = 0;
            byte[] bBuffer = new byte[header.BODYLEN];
            sizeToRead = (int)header.BODYLEN;

            while(sizeToRead > 0)
            {
                byte[] buffer = new byte[sizeToRead];
                int recv = reader.Read(buffer, 0, sizeToRead);
                if (recv == 0)
                    return null;

                buffer.CopyTo(bBuffer, totalRecv);
                totalRecv += recv;
                sizeToRead -= recv;
            }

            ISerializable body = null;
            switch (header.MSGTYPE)
            {
                case CONSTATNS.REQ_FILE_SEND:
                    body = new BodyRequest(bBuffer);
                    break;
                case CONSTATNS.REP_FILE_SEND:
                    body = new BodyResponse(bBuffer);
                    break;
                case CONSTATNS.FILE_SEND_DATA:
                    body = new BodyData(bBuffer);
                    break;
                case CONSTATNS.FILE_SEND_RES:
                    body = new BodyResult(bBuffer);
                    break;
            }

            return new Message() { Header = header, Body = body };
        }
    }
}
