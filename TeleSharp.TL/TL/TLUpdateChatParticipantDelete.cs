using System.IO;

namespace TeleSharp.TL
{
    [TLObject(1851755554)]
    public class TLUpdateChatParticipantDelete : TLAbsUpdate
    {
        public override int Constructor => 1851755554;

        public int chat_id { get; set; }
        public int user_id { get; set; }
        public int version { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            chat_id = br.ReadInt32();
            user_id = br.ReadInt32();
            version = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(chat_id);
            bw.Write(user_id);
            bw.Write(version);
        }
    }
}