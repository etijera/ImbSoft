using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils;

namespace UsuarioControles
{
    public partial class TxtBase : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades
        public CharacterCasing TextMayusMinus
        {
            get
            {
                return TxtTex.Properties.CharacterCasing;
            }
            set
            {
                TxtTex.Properties.CharacterCasing = value;
            }
        }

        public int MaxLenght
        {
            get
            {
                return TxtTex.Properties.MaxLength;
            }
            set
            {
                TxtTex.Properties.MaxLength = value;
            }
        }

        public bool SoloLectura
        {
            get
            {
                return TxtTex.Properties.ReadOnly;
            }
            set
            {
                TxtTex.Properties.ReadOnly = value;
            }
        }

        public MaskType TipoMascara
        {
            get
            {
                return TxtTex.Properties.Mask.MaskType;
            }
            set
            {
                TxtTex.Properties.Mask.MaskType = value;
            }
        }

        public Referencias.Funciones.TipoNumerico TipoFormato
        {
            get
            {
                return tipoFormato;
            }
            set
            {
                tipoFormato = value;
            }
        }

        public HorzAlignment AlineacionHorizontal 
        {
            get
            {
                return TxtTex.Properties.Appearance.TextOptions.HAlignment;
            }
            set
            {
                TxtTex.Properties.Appearance.TextOptions.HAlignment = value;
            }
        }

        #endregion

        #region Variables

        private Referencias.Funciones.TipoNumerico tipoFormato;

        #endregion

        #region Metodos
        public TxtBase()
        {
            InitializeComponent();
        }

        public void AsignarTipoFormatoNumerico()
        {
            if (TipoMascara == MaskType.Numeric)
            {
                if (TipoFormato == Referencias.Funciones.TipoNumerico.Decimal)
                {
                    TxtTex.Properties.Mask.EditMask = "n0";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                }

                if (TipoFormato == Referencias.Funciones.TipoNumerico.Numerico1)
                {
                    TxtTex.Properties.Mask.EditMask = "n1";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                }

                if (TipoFormato == Referencias.Funciones.TipoNumerico.Numerico2)
                {
                    TxtTex.Properties.Mask.EditMask = "n2";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                }

                if (TipoFormato == Referencias.Funciones.TipoNumerico.Numerico3)
                {
                    TxtTex.Properties.Mask.EditMask = "n3";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                }

                if (TipoFormato == Referencias.Funciones.TipoNumerico.Porcentaje1)
                {
                    TxtTex.Properties.Mask.EditMask = "P1";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                }

                if (TipoFormato == Referencias.Funciones.TipoNumerico.Porcentaje2)
                {
                    TxtTex.Properties.Mask.EditMask = "P2";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                }

                if (TipoFormato == Referencias.Funciones.TipoNumerico.Porcentaje3)
                {
                    TxtTex.Properties.Mask.EditMask = "P3";
                    TxtTex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    TxtTex.Properties.Mask.UseMaskAsDisplayFormat = true;
                } 
             
            }
        }

        #endregion
    }
}
