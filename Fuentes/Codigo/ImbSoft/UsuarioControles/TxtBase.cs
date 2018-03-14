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
using System.Reflection;
using DevExpress.XtraEditors.Controls;

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

        public char CaraterPassword
        {
            get
            {
                return TxtTex.Properties.PasswordChar;
            }
            set
            {
                TxtTex.Properties.PasswordChar = value;
            }
        }

        public string Texto
        {
            get
            {
                return TxtTex.Text;
            }
            set
            {
                TxtTex.Text = value;
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

        public String MTextChanged { get; set; }
        public String MSpin { get; set; }

        public object Value
        {
            get
            {
                return TxtTex.EditValue;
            }
            set
            {
                TxtTex.EditValue = value;
            }
        }

        public bool UseMaskAsDisplayFormat
        {
            get
            {
                return TxtTex.Properties.Mask.UseMaskAsDisplayFormat;
            }
            set
            {
                TxtTex.Properties.Mask.UseMaskAsDisplayFormat = value;
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

        #region Eventos
        private void TxtTex_Enter(object sender, EventArgs e)
        {
            TxtTex.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        }


        private void TxtTex_Leave(object sender, EventArgs e)
        {
            TxtTex.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
        }

        private void TxtTex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(MTextChanged))
                {
                    Type cType = ParentForm.GetType();
                    MethodInfo mi = cType.GetMethod("TextChanged", new Type[] { typeof(object), typeof(EventArgs) });
                    mi.Invoke(ParentForm, new object[] { sender, e });
                }
                else
                {
                    Type cType = ParentForm.GetType();                    
                    MethodInfo mi = cType.GetMethod(MTextChanged, new Type[] { typeof(object), typeof(EventArgs) });
                    mi.Invoke(ParentForm, new object[] { sender, e });
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TxtTex_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(MSpin))
                {
                    Type cType = ParentForm.GetType();
                    MethodInfo mi = cType.GetMethod("Spin", new Type[] { typeof(object), typeof(SpinEventArgs) });
                    mi.Invoke(ParentForm, new object[] { sender, e });
                }
                else
                {
                    Type cType = ParentForm.GetType();
                    MethodInfo mi = cType.GetMethod(MSpin, new Type[] { typeof(object), typeof(SpinEventArgs) });
                    mi.Invoke(ParentForm, new object[]{sender, e});
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

    }
}
