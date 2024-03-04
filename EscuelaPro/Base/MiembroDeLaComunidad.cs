
namespace EscuelaPro.Base
{
    public abstract class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int edad { get; set; }
        public string lugarDeresidencia { get; set; }

        public abstract void comer();
        public abstract void ducharse();
    }

}
