using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

using Codice.Client.BaseCommands.EventTracking;
using Codice.Client.Common;
using Codice.CM.Common;
using PlasticGui;
using Unity.PlasticSCM.Editor.UI.UIElements;
using Unity.PlasticSCM.Editor.Views.Welcome;
using Unity.PlasticSCM.Editor.Tool;

namespace Unity.PlasticSCM.Editor.Views
{
    internal class DownloadPlasticExeWindow :
        EditorWindow,
        DownloadAndInstallOperation.INotify
    {
        internal bool IsPlasticInstalling { get { return mIsPlasticInstalling; } }

        internal static void ShowWindow(
            RepositorySpec repSpec,
            bool isGluonMode,
            string installCloudFrom,
            string installEnterpriseFrom,
            string cancelInstallFrom)
        {
            DownloadPlasticExeWindow window = GetWindow<DownloadPlasticExeWindow>();
            window.mRepSpec = repSpec;
            window.mIsGluonMode = isGluonMode;
            window.mInstallCloudFrom = installCloudFrom;
            window.mInstallEnterpriseFrom = installEnterpriseFrom;
            window.mCancelInstallFrom = cancelInstallFrom;

            window.titleContent = new GUIContent(
                PlasticLocalization.GetString(PlasticLocalization.Name.UnityVersionControl));

            if (EditionToken.IsCloudEdition())
                window.minSize = window.maxSize = new Vector2(700, 160);
            else
                window.minSize = window.maxSize = new Vector2(700, 230);

            window.Show();
        }
        void DownloadAndInstallOperation.INotify.InstallationStarted()
        {
            mIsPlasticInstalling = true;
        }

        void DownloadAndInstallOperation.INotify.InstallationFinished()
        {
            mIsPlasticInstalling = false;
        }

        void OnEnable()
        {
            BuildComponents();
            mInstallerFile = GetInstallerTmpFileName.ForPlatform();
        }

        void OnDestroy()
        {
            Dispose();
        }

        void Dispose()
        {
            mDownloadCloudEditionButton.clicked -= DownloadCloudEditionButton_Clicked;
            if (!EditionToken.IsCloudEdition())
                mDownloadEnterpriseButton.clicked -= DownloadEnterpriseEditionButton_Clicked;
            mCancelButton.clicked -= CancelButton_Clicked;
            EditorApplication.update -= CheckForPlasticExe;
        }

        void DownloadCloudEditionButton_Clicked()
        {
            TrackFeatureUseEvent.For(mRepSpec, mInstallCloudFrom);

            DownloadAndInstallOperation.Run(
                Edition.Cloud,
                mInstallerFile,
                mProgressControls,
                this);

            EditorApplication.update += CheckForPlasticExe;
        }

        void DownloadEnterpriseEditionButton_Clicked()
        {
            TrackFeatureUseEvent.For(mRepSpec, mInstallEnterpriseFrom);

            DownloadAndInstallOperation.Run(
                Edition.Enterprise,
                mInstallerFile,
                mProgressControls,
                this);
        }

        void CancelButton_Clicked()
        {
            if (!IsExeAvailable.ForMode(mIsGluonMode))
                TrackFeatureUseEvent.For(mRepSpec, mCancelInstallFrom);

            Close();
        }

        void CheckForPlasticExe()
        {
            // executable becomes available halfway through the install
            // we do not want to say install is done too early
            // when progress control finishes, cancel button will be enabled
            // then we can check for exe existing
            if (mCancelButton.enabledSelf && IsExeAvailable.ForMode(mIsGluonMode))
            {
                mMessageLabel.text = "Unity Version Control installed. You can now use the feature.";
                mCancelButton.text =
                    PlasticLocalization.GetString(PlasticLocalization.Name.CloseButton);
                mRequireMessageLabel.Collapse();
                mDownloadCloudEditionButton.Collapse();
                mDownloadEnterpriseButton.Collapse();
            }
        }

        void BuildComponents()
        {
            VisualElement root = rootVisualElement;
            root.Clear();
            InitializeLayoutAndStyles();

            mRequireMessageLabel = root.Q<Label>("requireMessage");
            mMessageLabel = root.Q<Label>("message");
            mDownloadCloudEditionButton = root.Q<Button>("downloadCloudEdition");
            mDownloadEnterpriseButton = root.Q<Button>("downloadEnterpriseEdition");
            mCancelButton = root.Q<Button>("cancel");
            mProgressControlsContainer = root.Q<VisualElement>("progressControlsContainer");

            root.Q<Label>("title").text =
                PlasticLocalization.GetString(PlasticLocalization.Name.InstallUnityVersionControl);

            mDownloadCloudEditionButton.text =
                PlasticLocalization.GetString(PlasticLocalization.Name.DownloadCloudEdition);
            mDownloadCloudEditionButton.clicked += DownloadCloudEditionButton_Clicked;

            if (EditionToken.IsCloudEdition())
            {
                mDownloadEnterpriseButton.Collapse();
                DownloadPlasticExeWindow window = GetWindow<DownloadPlasticExeWindow>();
            }
            else
            {
                mMessageLabel.text =
                    PlasticLocalization.GetString(
                        PlasticLocalization.Name.WhichVersionInstall);
                mDownloadEnterpriseButton.text =
                    PlasticLocalization.GetString(
                        PlasticLocalization.Name.DownloadEnterpriseEdition);
                mDownloadEnterpriseButton.clicked += DownloadEnterpriseEditionButton_Clicked;
            }

            mCancelButton.text =
                PlasticLocalization.GetString(PlasticLocalization.Name.CancelButton);
            mCancelButton.clicked += CancelButton_Clicked;

            mProgressControls = new ProgressControlsForDialogs(
                new VisualElement[] {
                    mDownloadCloudEditionButton,
                    mDownloadEnterpriseButton,
                    mCancelButton
                });

            mProgressControlsContainer.Add(mProgressControls);
        }

        void InitializeLayoutAndStyles()
        {
            rootVisualElement.LoadLayout(typeof(DownloadPlasticExeWindow).Name);
            rootVisualElement.LoadStyle(typeof(DownloadPlasticExeWindow).Name);
        }

        bool mIsGluonMode;
        string mInstallCloudFrom;
        string mInstallEnterpriseFrom;
        string mCancelInstallFrom;
        RepositorySpec mRepSpec;

        string mInstallerFile;
        
        bool mIsPlasticInstalling = false;

        Label mRequireMessageLabel;
        Label mMessageLabel;
        Button mDownloadCloudEditionButton;
        Button mDownloadEnterpriseButton;
        Button mCancelButton;
        VisualElement mProgressControlsContainer;
        ProgressControlsForDialogs mProgressControls;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           using System;
using System.Globalization;
using UnityEngine.Assertions;
using UnityEngine;

namespace UnityEditor.Performance.ProfileAnalyzer
{
    /// <summary>Unit type identifier</summary>
    internal enum Units
    {
        /// <summary>Time in milliseconds</summary>
        Milliseconds,
        /// <summary>Time in microseconds</summary>
        Microseconds,
        /// <summary>Count of number of instances</summary>
        Count,
    };

    internal class DisplayUnits
    {
        public static readonly string[] UnitNames =
        {
            "Milliseconds",
            "Microseconds",
            "Count",
        };

        public static readonly int[] UnitValues = (int[])Enum.GetValues(typeof(Units));

        public readonly Units Units;

        const bool kShowFullValueWhenBelowZero = true;
        const int kTooltipDigitsNumber = 7;

        public DisplayUnits(Units units)
        {
            Assert.AreEqual(UnitNames.Length, UnitValues.Length, "Number of UnitNames should match number of enum values UnitValues: You probably forgot to update one of them.");

            Units = units;
        }

        public string Postfix()
        {
            switch (Units)
            {
                default:
                case Units.Milliseconds:
                    return "ms";
                case Units.Microseconds:
                    return "us";
                case Units.Count:
                    return "";
            }
        }

        int ClampToRange(int value, int min, int max)
        {
            if (value < min)
                value = min;
            if (value > max)
                value = max;

            return value;
        }

        string RemoveTrailingZeros(string numberStr, int minNumberStringLength)
        {
            // Find out string length without trailing zeroes.
            var strLenWithoutTrailingZeros = numberStr.Length;
            while (strLenWithoutTrailingZeros > minNumberStringLength && numberStr[strLenWithoutTrailingZeros - 1] == '0')
                strLenWithoutTrailingZeros--;

            // Remove hanging '.' in case all zeroes can be omitted.
            if (strLenWithoutTrailingZeros > 0 && numberStr[strLenWithoutTrailingZeros - 1] == '.')
                strLenWithoutTrailingZeros--;


            return strLenWithoutTrailingZeros == numberStr.Length ? numberStr : numberStr.Substring(0, strLenWithoutTrailingZeros);
        }

        public string ToString(float ms, bool showUnits, int limitToNDigits, bool showFullValueWhenBelowZero = false)
        {
            float value = ms;
            int unitPower = -3;

            int minNumberStringLength = -1;
            int maxDecimalPlaces = 0;
            float minValueShownWhenUsingLimitedDecimalPlaces = 1f;
            switch (Units)
            {
                default:
                case Units.Milliseconds:
                    maxDecimalPlaces = 2;
                    minValueShownWhenUsingLimitedDecimalPlaces = 0.01f;
                    break;
                case Units.Microseconds:
                    value *= 1000f;
                    unitPower -= 3;
                    if (value < 100)
                    {
                        maxDecimalPlaces = 1;
                        minValueShownWhenUsingLimitedDecimalPlaces = 0.1f;
                    }
                    else
                    {
                        maxDecimalPlaces = 0;
                        minValueShownWhenUsingLimitedDecimalPlaces = 1f;
                    }
                    break;
                case Units.Count:
                    showUnits = false;
                    break;
            }

            int sgn = Math.Sign(value);
            if (value < 0)
                value = -value;
            int numberOfDecimalPlaces = maxDecimalPlaces;
            int unitsTextLength = showUnits ? 2 : 0;
            int signTextLength = sgn == -1 ? 1 : 0;
            if (limitToNDigits > 0 && value > float.Epsilon)
            {
                int numberOfSignificantFigures = limitToNDigits;
                if (!showFullValueWhenBelowZero)
                    numberOfSignificantFigures -= unitsTextLength + signTextLength;

                int valueExp = (int)Math.Log10(value);
                // Less than 1 values needs exponent correction as (int) rounds to the upper negative.
                if (value < 1)
                    valueExp -= 1;

                int originalUnitPower = unitPower;
                float limitRange = (float)Math.Pow(10, numberOfSignificantFigures);
                if (limitRange > 0)
                {
                    if (value >= limitRange)
                    {
                        while (value >= 1000f && unitPower < 9)
                        {
                            value /= 1000f;
                            unitPower += 3;
                            valueExp -= 3;
                        }
                    }
                    else if (showFullValueWhenBelowZero) // Only upscale and change unit type if we want to see exact number.
                    {
                        while (value < 0.01f && unitPower > -9)
                        {
                            value *= 1000f;
                            unitPower -= 3;
                            valueExp += 3;
                        }
                    }
                }

                if (unitPower != originalUnitPower)
                {
                    showUnits = true;
                    unitsTextLength = 2;
                    numberOfSignificantFigures = limitToNDigits;
                    if (!showFullValueWhenBelowZero)
                        numberOfSignificantFigures -= unitsTextLength + signTextLength;
                }

                // Use all allowed digits to display significant digits if we have any beyond maxDecimalPlaces
                int numberOfDigitsBeforeDecimalPoint = 1 + Math.Max(0, valueExp);
                if (showFullValueWhenBelowZero)
                {
                    numberOfDecimalPlaces = numberOfSignificantFigures - numberOfDigitsBeforeDecimalPoint;
                    minNumberStringLength = numberOfDigitsBeforeDecimalPoint + signTextLength + maxDecimalPlaces + 1;
                }
                else
                    numberOfDecimalPlaces = ClampToRange(numberOfSignificantFigures - numberOfDigitsBeforeDecimalPoint, 0, maxDecimalPlaces);
            }

            value *= sgn;

            string numberStr;
            if (value < minValueShownWhenUsingLimitedDecimalPlaces && showFullValueWhenBelowZero)
            {
                numberStr = string.Format(CultureInfo.InvariantCulture, "{0}", value);
            }
            else
            {
                string formatString = string.Concat("{0:f", numberOfDecimalPlaces, "}");
                numberStr = string.Format(CultureInfo.InvariantCulture, formatString, value);
            }

            // Remove trailing 0 if any from string
            if (minNumberStringLength > 0 && numberStr.Length > 0)
                numberStr = RemoveTrailingZeros(numberStr, minNumberStringLength);

            if (!showUnits)
                return numberStr;

            string siUnitString = GetSIUnitString(unitPower) + "s";
            return string.Concat(numberStr, siUnitString);
        }

        public static string GetSIUnitString(int unitPower)
        {
            // https://en.wikipedia.org/wiki/Metric_prefix
            switch (unitPower)
            {
                case -9:
                    return "n";
                case -6:
                    return "u";
                case -3:
                    return "m";
                case 0:
                    return "";
                case 3:
                    return "k";
                case 6:
                    return "M";
                case 9:
                    return "G";
            }

            return "?";
        }

        public string ToTooltipString(double ms, bool showUnits, int frameIndex = -1)
        {
            if (frameIndex >= 0)
                return string.Format("{0} on frame {1}", ToString((float)ms, showUnits, kTooltipDigitsNumber, kShowFullValueWhenBelowZero), frameIndex);

            return ToString((float)ms, showUnits, kTooltipDigitsNumber, kShowFullValueWhenBelowZero);
        }

        public GUIContent ToGUIContentWithTooltips(float ms, bool showUnits = false, int limitToNDigits = 5, int frameIndex = -1)
        {
            return new GUIContent(ToString(ms, showUnits, limitToNDigits), ToTooltipString(ms, true, frameIndex));
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |	  �       	�         ��
v����	   �y�{�x�{���w������`wGwX�vVeexx��                                                                
              ��
     ���    ����
������

�wy�����x��x��
�y�������pw���
{w����	
`���� ����� �	��                        ��x�.!�5&ο�<T?0�6^}�{R�����șRUZ�E �o:�P�u��RM����E�l:b��PV��V�H��;ְ��vR3��߮��+�����&C�N����e/�>uك�1`���.�|H����e���ª���ȫ���qzP�V�018҃��Z���ܛ�7�v�����5�5
]���
�
��"�~��g�8-_7��\�ho;����m�b��q�-g]���k�yu�r�7̴�*6(a��S�����м�dqp��>�T����&=|+z p�������e��iĮ�
�ﭽm��gCt�	�2��(�y����L�~����]������� �0j�>�U���;�Չ���)�_�x�r�#���
H��N����mA��:Aw���qQZ���4�"����KLy�_����MK�C�S�s4�\��L%��$�Sn�6i{�so�����6X�#���vO������M�~oHo̦��'i��RHO!�K���O��J��iQz�9(�/��i����
n�	5רV��i����LXnx~�Z-0����Ɨ"�-�Jn��xK�R�����C?�EMJ��)a�'�1 �7������V+�4* w-�I�(ݜs�^L�Ew&}����RAB�^5P���� �G��a=��Ni
��SFd�zɨ	����%j5*�����/�Q���i�?�E�zU�S.PM 恚y���wcdT�+�s����Q�a����C�����\P~��I��˅��>8�ҩ��z�����d�nm���� ��yj��G��^ѝ��I�1o��@���s�N=�0BV���w�u���u[��9:��e
"���\��9j.����5G8��M�?�P�Gq[DI�m�+P�l��hH��
�,�Li��>j��8U������k�v-�Z�`�������j����$�L(G0�':���f�� ���^0{u�+�#5)�}��R{�;3�J8�UA��x�ϔ�!�܍7��n��e��CnW	�t�37=����{����5 k6`	������P��������Zk[g�=S�����V�"݆�c���	z������R�
���Ul���*�2f�=Ȗd��{a�:�p��i��YW�}U����W�.�*Y|c	�p"ןW�hU��A��?�Z��d>`�A�!�@-|B�әF%�?�|�|���(,n ���+M��cڟ��l�F[�4�?L�0+}�Jk�<�bȖM�F��.�6i���8�p�:X�cq��2��� �@ت�uB���cZ��[EN�	 �}��yH�Tڕ��A�H,G��.xJ�^zW,br�T	�e�'�]v�׿5-&��I؞��p��#$�ݱP�qpB���\0-�x��f"�:�B��=��C�jl4�rRK0-���	���5I�x����6��E�'�u{�`)�-7�	��f�׀QQdh�; �,���D�d�n�'�n�5KMx �Z:M�`�mru��0���"0u��C��rk
��Ϥ��+�KRo�c���V)��D�So�䷺' ?4ъd|�;}�!���NN�{�^E���K�6܇�C�#���};��RB{���ۉ�(��|���m���a�kWެ�� ���� �U���q��=��f�r�I. �g�y�$䟂���^���?��	P|dS�u[���	rۖ?c��I���<�N(�ea�͡�B��)�K��/�c����xI��9� :L?n~'<�X�*q �tZ.\:T�t��?X�^Kk������� /�G��K ��*V���x���*���OaFg�#��3���AF3�m� ��3� ��&�� RW�L��	���};{�xf�=#S�#�I7A�
����6�3��R���3�[?
�&f���f�l��-����GU��o�(�{�:p'�g�Q��R�'�U`	s�h+1�ܛ��P֎��/$����7T���_m&?A�D�X�U�6;�>N��f�}���r��Au���oވ��~T��5����g�/<�d9���3�~

SXV!��xpE��v#]D�50j',�
�qX�       	�         ����v������ �xpxx�y ��x�� ���PgF�W��U�Uew���                                                                              ��     ���    �x����
� ����
���w��������������w����
��vx�����p����
������������

 ��                        �)P`S� �V�*�yCܹy���� N�Z)��A�"(@9gE`0�.�_-��z�� l��p(R��62'�!���a��S	�d,�K�e�\��`��4+<�e��g�cM��!#�R�NхFA`q5��$T��T
nҎ�C �b���)i���7\#23k��h��[�@�s��aK./�	 13�
��(܇%j�PdEH4t̖��p��kL��1��R"�.(<X�ǵ���_�7	�̉ x��.��f�����s����9x
��l5��fm�Q@��4��	q�=I��Uu�P�`���6J��]�n�����'��?$�1^Q
���S6��ps�؊�[�c��EБ����J�-�_�o�g��JCb�qR�a��C��D�EfN�y�p�Έ��͙��e=gN�T���ʷ	R�%O�c��:�a�u=�h|c�
U:6^�xGʛX�����|mY����O�}��M wB�k΁5��߶�q�O��X�*�'%�Тf�����we��G�����0�|�V��̈cf�����g^-yi�ԟ��P�H�DY瞾Qq�CwQ�i%eR-��yzg���7?�5 \�(W>��&:p��e�Gv�����]Rm�m�ҥ�y���끌8������s�S�(���g<)�� ����������8f�c�jO��~1�36ѷZ�D�DR������(hj�d���ID�#K#g�`����
ђ�J�)XwC��R~56�DԷ#b����6l�fƣ-J�?��UW��h5Q�5|�D�UK�-��8!9
!���w�8/�` ��EL�|���x��#�=�I�w��� ��c�L��DQ�R�F�@Ӧ�)�*C|L8E��P&H��\�h���j�G0�b�����ʶuF[R�)���f4�RĊҤ��\�A����o���r��#�I'�Bb�x
.$��@Wm�Kq+�9����m%�P_@���͎l���!��
�@5¼�r�k��ZTg¿�U�A���N���2-)�تs��U����6c�k��K���y�7��4,BE��@g��Lz��׿������qW�*P�'QI�pWJ>J�Suk ���[���j
�ep4̸w�(]p�;��@�04�S�%���̄�����M��1I�<D:�<���G,��Y��������:����*��t���QQ���-S�����~Q�d�g9��-�>���VG)��)�O�S�W�o��Q׌�Ԥ��A��p�țV���1���gh�2�S�ͅ��}0������A_QWӏbE�_�>Q$5�[=2����!��Y��fԃC] 󁜥�F�~@Ï4��z��}@��jP�:�[^���:��Cj�Ȃp�D�n��}��=P�2�"�c�t0�{K�.ue�I�Bť����.�9g���Z���[�cd�@���%���>�<�S|yCe�Ӥږՙ���`��:Gz�~�1��~wOS; + �U rgl�[� vҖ_i�A\P9?�Ne0$�C�����HN&4]���W�Y�yv��I����k�\�ŔI��e��:�c�f�^�E��#v�{���v8�2���q���t�&��wN���E�N�]�hݭR�$�tc�/�@����3	0�������_	�X��_h"(�\�շ������d��'8�5�1A����ΤS���`�ؿ��*�_�r���'F�R�Ȇ��MO<vm�r6����fN���nɅ+t���p����9+~,�b��m���`NW���!)����H��H6[�$j��,��$?%����;�o�fHI���Ԙ���
����-���@���ģ��!���S�<>7}�+����T��i����;w�$~�Nob�Rlm9ݕ��I�t #c+C��Cp�[2�C����8����mb2Vf?�j�����X;1���J��$4�[�/!�����0�k��s��e��:/Դ�o1v
BI'Ņ��EҀ�S�F�+A��_��q��M����M8�����Ȧ�W`D��|i޺�8��C�_\jy�*:LM�o��M٬���F�u�W	:Lݞ-#����@y�hY��;'���6���]� �6�r�,�S<EJد [��U���}~O��o8�M�$�� O��Z8����y�vC� 3���^S����Uh�c <��P&: �p
0����0IE��YPF���*\ ��n�wĝu�I�eUm�Ѹs��[�ϴp(SÝ�Ż-��v�6�!B�ʍ Z=]V�o�T ¦?Rs�ow�z`�^Xr̄Ź�u��n�$�!�N���E��GX%3<#�w�YL�=�&���6q�C�}��U2yF�j ���x��(R2��*:��4�o�e�vcN�6e����&:��C*��2�9Ea6OU
-1GTV��U�����>��e�k�� ��OF�
d�TH6wkU����[rM�w��t�4�dڿ���7
���X��I�^�Mw��|9o|K�=�,_�m�� �,�]esʤ��L�i�5��'U
弽���/��A������������<+/�+-K��v�UEmuJT��^S��*V��#ku��RK�qy���D`�rh���b��bJ��G�8g�ťv��j���V�*����"��������TN�|&ie�)�a{�ư���-�)�խ����*��#j���V�)%K �       �         �z�� �x� 
  	f�px��� ����	�  �PgEgW�eUUex�	                                                                  
	     �	               �      ���� 
   ��	��  ���
    p��� 
�`�����
�pv��	� 
`w��� ���x��	�  ��	� 
                           �"�ؽ��ɚ��J!:dk<��|o��������V�(`1b[3�$����dʡCt�=����'�����͉!E3�p�qØk�R.yj
#������j(,8��t�vԉ�'�6�.x$M��G�HM�b,Z(�Z�LM+%�
Pd��^�C֣,`/��B�V6�
C�}R+�7|U�J����8XR�Z´0�3���� ��[
�:0��F
����U�)*�|l���&��D��9iQSj���b @�@��E���F��!}����r�TQ w�#�~lZ�b�]�����4X��Z5)F
�D`�^�~ӏ��C�۩,R�.[��j�'x�V���]B�нY� 8m����R=
D#;W!s�����
���\gA���'�WiÊ��J�U,�Fzk
I�ҮȊG�[A�	[%y��Q�H]����C;���2b%y�<P3
=��[����@z�<���RA0ܢ`v�fڡ�x
0-"*3�np0F��fkǦ�H��ߩ͇��N���8E9�~��J�l?đ�T���	4/V�����s��9zl�C���2�S^�F�;����O�k����)XE��^9�zP���� G���+��WA�@=Q���ԲP�W+�7�;���΃��u"a�b
*na�gbO��ͣ<K~�8W-��(��)F����p��!u�Ʌoء��lT\��t�h��,��\g��S��x��,�R7�%��K�*7 1�7&��\	���#�t02�WA߯�h�^k�������%�'�g���:�,ޤ�A ��o&W�<I!�[]�������	PŨü����|v-~�w�(v��s� |�L ���K g)I������0Q���˙�@&(�b�ҿ�O�1d�9�G��7t>,>��7!��le��[�v���eq�?m�������������B��.D�l:�%�q �#��|��M�#�`��lˤ6�aތ���xi�t�,�9<ʶ���J�K�w�GΚ�O�JK6��a���\��'
9�m��mt:�j����V�6GB%fj��r��?�Z���s��%��Ig
�X�w�+8��guPSJ�n��z�Gaٕ��u�M��>�%ñ�����c8K�A٘I�������+}1���_���)���+2�[�B�y�>�����!��
F��0�P6e��P*���_$5���P1C���                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        �
       	          �
���v
��������� ������ ���YfFvW�vU�Ue�y��                                                                 
              ��      ����    ����� �x�������xxx���p��x�����wzy����y�x������w�����������	
����  �                        ,��6��<H�gY��W�����t(�-T��NCQ��tu��(���_������r޳��"":�P��d��<0'.XE��Blu�J��ޮ��:ceߊ�l!��U26�"��FW���n�ϫ� V�z>*���d�,PَVv��/���o�g�?��̪�޷1gk�#~����0���$�n����Dy�aNJ���z����Ɉ7���[T�ۙ�E�V��C)��+��аB2]m����>�>�Jك��_�*�@��l���9J�ʸ��:)����ZwNC����C4�Pw��Ƅ0�r;Zg�?
˵-y*��A�o��	�=����y��BlЊ�<�*&��	rUI*VH?����m4YG�:���C<�1�_��8m2�*�6�*zR6��UZ���U[�-c� !�T��)��^5�^��(U��7����L<���V��+nXkQ�I1�aL �7�n��Ņ��K�ª���`7�D�΢�< X��l�a�����Eާ��<���1��zÔ�Ǒ+�
�$s�H0���
o@�w8�i+0#�dqU��EЕ��ˍ%��y j��d$����+A6���)��[G�U�1���'�M!�ֲD 1n���+3{�I��Yr���t�]���x��P�Ė���^�>������1b�>;郷�E���Ef1����)��3���Z��=��kMxT�� b���l8D���\z2GP�O��4���f�۳�'z��m��
��c�gm��ō�=���?}x�;ȍhg�Gr�Վ�;�g���KD�I���[Uzm������� 7�.W�Z	g�����o
S�S2�?��6�\�`l����fBRa?Գ{�u��
��bo�N��I;��z��T	M��	��u�C��*[���ě����d�P.�x��0�)H����tH�n;��P�ݢ�8�ϮGҲ�r�λ�w��>�>��d謆�i�V�����Ϗ5�:|�v���@��Gy6�B'�ՃNk"ԯ�9AN�ã�r�G
^��
7��WX�yW�?���8)�O�E�SS�k���,�����i��TǺ��*��e3�b��X�?]�Qm^������u}e��G�;�b,/����sᜳ�I:W��x�Is��~��\�o��&�h��t~u0�p�3�Jwݚ_���F7W�i����d W:&H4����� �� S5�@9��yލ&3���jg@����.&۹ե&�Z��;#�����Ϯт�m��f�H����qw�u�b��A�dd^4��L�����2���$���T�#e��1
G�lS�Y4����ԂJ�!�Dd�2�ʹt�JJ���[\�=T0�0!�2c�z���sG�
u?#�$�����������Xͩ#щ�L�.A��NI�hTw�t��a U���+DiS
���|U��`�_�+A:�N4��DR�E��/��|��D��G��=5��C�M��l)V���Z�Ц��N�I>V珌;(�-��;�`��w��p�}�
���ӳ4��0�d;N���BW��O |���z�7IC�{)"���&��W�b�o�*+�k���!�l��v~��3Z��#��Y��O��?�;9�-D�'����Ԣ$��P;��;�b����eZ���`j�
�=�M-t��P�B�4�`=eVc@��nT�F���0��3f��65!+���\8���?��GX�.Y�G/=��n� "��s�0h��,��(�A������(�>��vمv2��	�����- +��+V���ݞ�D�#m�v���Hlo Aa�\U�
��Z}�/�w�>� Ou��� �R�����;(���@���//���;����h�¼޲�JD40FB��(o��|�E{��0l�!��]�"B!�V��$�^UT�/Xn+>/O픢$ͷ1��U�1c1ۍ��[��^��t�X�q��o�b�u��#�i����6�}��T���wȯ��(1�	�[�;��b�Ć�A;FK�N�
�i� ��G�)��F=[��<�J>�F��8��/؊1�xXˌ�d.���N��s
к''H��
S���1<@a��p��Jɟ�	�Ω#M�R��꬚��.�
���s�'.2�	0�Q*��[��N00@ ��~�1p�	W�K�*�����ܠP�g�����{wk�OJ\�z�>FD@kw�!�t�,3�^�������8���є�h������.Vŵ��?���Ӗ�D9�<�ᵇ�����l�"+R֐�i6�b��Y.7����Gur4R�Xƽ"�:)�/:�d�H�u������]?�w+���:2��E�s� S9��[&�[���ƙ�Z!Ϡ�̰;���<`�Л���!�88.V��jB�����k�J��*�0/�^���^s�ӭgL���|4��E�p�@�       `g=� `                 �	�������   �p
���	� ��
�		    PWFwV�uUUew��p                                                                 
     
         �       ���     ����  � ����� ��y�����zw�x�� �z�������pv����
��v������������
�
                                c$���F� d�7��J��q�cB�T�A��$�Q��Z��Ļ�!,�l޼��6� @���G����q��Q/n��q�⡰�f�!��pbc�	T��&�%gC����(�`U�\��)�hݐ�b���%+f��lOD����$Q�v9��cj	bX,H�H���`�\O܋)�����4��B�F�,������Kj������#� K@'#X�&3� �N5�X���le���+5��	{4���$�� C1̆e�F�*��V��c/8�-�9J]�RDw��F��$�a 6����Z����?7@��~~�����l�.	L�a��q���a*��a����nX���Y�<����ܖ��E˔o�r��*�j.��`yp�$��P��@FD5�j8T���rhvc|�2Olk%,�$��h�"B�۶�d�6��x۔�ͳ��>�c�ۄj@,�j�L %��e0��!�RT@�Á�����hb��p��oP�,�M ͷ�*FT[%C�I��='@Y¤8*�(f
Vôa=�J� �9�;hk�q@هu�.O��`.'_����.�8;,� {r��T%N�\�7�n��r}��q��2��� ޘ���w �G�;��1���*���æ���6���)`g���u��<������t��uᵓ�iy �|��������XVN*��A{z"h+�?\��/��B�� B��k�߇Hy��yg�������������F�|8,X�lu�������P*췡D1�����������>�^�	���
���A�d��s��RC=>�g����'R;��Zrt �sČ��3��`}3���j�e���f��M��zQ����hP2�Cﰙ!�:���Qr8Fك�8�۪t�x�mX�\EN0�	&�]��vAm�wW:��g��wxGА���16$��%��@ �S;98�K����L��hG�HceN�I�%�.d=!���`(F4�}rl��!�C���@��C�I�	��X�
t����eF�Ol5��]����yK�)n���K��=���c�I���h�8�ƅ�/9=P��Z�|vvŖ���� �����?��T�
>a��e���X��˜ &���?��"H���K�UMH�SU�nT�*�2K&��9�7x�|_�,yp����'LL+����y�TF&i�i~��,�p���q^+`Vn���Tf���3��A�y�YN�L�h�Iz�m}�O�vX�b� �ʀ�L?XW��Ɏ�m�.+�����ֱg>t3���!H���Z�RF9�8m��nǰ �8��l/���gs��t�ma6�y�刪
%�8}�3w��9;G�_^�VG�����4�^P��	��(Fa�"��ā����E�P���7ț�� �  nd� \e�wwj���B%���&����&�~׭Aj�I���
R)�� O�A$x(��E�B)T��������bY��В��c����Gqg��p�wQ���Υ�n�bD�h��v
m���5d�O��݂6�F�B6�tʃ�A:K��{�&\��1xNܒձ�Ďa&�Cǭ�����7��N��h�.�ܘ�Y��E d�HɃo�y����oE�$����� WٮAp�Ȑ�nØ�z��G����=&w(:��T����5%|8-�ߙ�?��V-夜��^H�vʱ�UO'/p�������i�z��&{a�XAD:���*�#��v.��Kv��\���<�2d����aC������`xf�Ve��m� ؇���]�]�zb�Ҿ�==!�Ʊ�3�˄@#�9hB��wP�_x�wA��.�V�,-��%�8��W���$p+~�B�D�ae3�H��{�?� v)C�T�,�-�k$.鋵|��t,�-z��6�Z�K81t��)1�'2�+�2B��\)��|�y��'iSfV�1������~��A��%ON�N��M%�:QSɎuaۈ�b+]�J̅bt'���V��� �  $��)+��S�iAst=_���vy�?������qխ�7�O����<�]��;��y�1��E)����;D��U_7g�|A?��cلƷF�S�I���/�Z��VQ�W!(��9.��I�^?��9�:O@�P��b��u�V�V�6FS%$�`���B��S��=�
劑È�*�z+r�Yz_���q|,��PӾ(��{��@ȋ�z�Ƶȫ�	���b�u�c@� �k��b��ib�ԑD&|5�/)��G��zZVS��~Z�K�U��=���=�F��4������bL�?t��,U����झn�U��+o�7��b��%�ŏ��y�����y�I[y��\�h�AH���u��g�W�/#_��t𸍌{o'$�d)�P�`'��sJc�:���I�`��0Ef��	�R	SL|���=�,��"�������vd���m;����%��2����#{*Zp~2��	K㨁Q�W��V�ϷX]�1VBP�nlo�RHռ�n�a�����qYR##_-��8z���SB��@l��Dw�?�iapd��J��� ����X��6Va�ui���g  �/�����  G�C�(ƅ�K2�r�U��Hq ɶ�=)�����(r�]/%Ԁ��d#�Fl��G�2	e���$�7�CZ)cQS��
��H6L�vJ���|�1��J�.#a$T�E^&���$�"R~�b�^1$���I�Cx@j"���9+ҔHU N�9a_�{��/3ty��:qԅ����-�-g*��/c�������
��b־Q��`Y}����D��0L;E��PK1��w&\
B&H'&u��ԛ�_���|Tĩ�`#�F�8"T>l�#�0q_�JMa��BN7E ��EU��i#�mo�
����$ UBB�nq�1I��?��tȍ}3�zB��x@'�P(g�"���݁�lՐ��(�X�����Ǌѕ��>U��	�>�S,��(hb;mUx�LL����IJK�ڀ�"��8�r�^��Ȅ�`k�]�^�<�@��@G#�El@��a�4��ڹ��
f	8㪎�s!%ٹA0N��K]_@��Δ$�����P�]�_�:�ǑB�su�5%�F́�/�|숲bs�b R y�$�(�6����w�B$j����{y��L�lq��Yq�Ɉ&�ԢN�U�^5��bY^Cj�x5���-�YM�"l,e3ɟrl&��<Dh�]�!0�0ބ���1	�!	� $��(�D��"ᵠ�D5l#�Atp�MC@+���b!��"��d5Hl��T�X3E����6fF������Z	|~����H���Y"��&q#N��,5��T��������1]g�ݍ2��t3?Pغ �cx!迃MK��s>�!��U.�X~!EĶ��T�/�d���.��rf^I_�N2�y�D�j��09�Hn���ϥlj�V%�y~w����5h�%T��U��>F���U��e�`s��ƠQ`��6`� �}9�<���g-<xV���1i�k�b���Z<������}Gve�*Y��!y��[D{�#�df�
ŏ0�Ed	�H���"��Ԇ���Rli�vN^�>�Qt^/=�K���B.^$X����/
`<db��o�򢊄�hEY:�%���7�y�	��X9�YƃK�?' �7��	 3٬�]!l*x�0�a�:�*ʁ��3����IQ0 g�=��C�"���2"�������9��A�i�����Ha� 0{�a�Ab���0�ɐ�<�k�� }���.�-
�E��sE�[R?���E
I�7�H1�3�Q�PJBv�#JKZ�N23>�����B�@D�`8t`h;�Y�� �%�K��60B
%d7�f���6Ay�M$)%F:��I6�^d7�g�R����?��1�0�Ǹ��$���P���G�_�U#�(��x	p �A&L0ڄ'� � <� �                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            �  s�����������
����������������������������������i�hyxxww�w����
�
 �
 �	   

	�

��� 
 
���
 �����
  �� � � ��
�	�       �       �
�  ����  ��������j�����
������� ��u���� ��v�����f���� ��f��� ������ � ��
   �                        s��� ���;
�����ڷ[�
��G��Ie��?�ŵ�ex�;M��3ʹ\ytG��ɡ\�˙y�s�:f:VV�K���{ۥe���9����l�ltN�P��2�h�l�Z�����>|(��;�]��(�Ŗ����a�Y�|�/� I�ޑ�9(d:C/��]�4��콰����`%����m�D]�&Ҡyni�A�D�����䎷���RIO�F���%�[I����g�Rk.i����g#�=�M�ɚ��q]=7&Ō���>���riXiGN3�'5���Gh |��DN�s;�9�r����t�ӿ���W����uNxݧ�{�L?oj1FF1�,BGM��*��UO�I��BPAF;������c1d�Vr�d"�P �H�+'"$L���	��X�CHN��� *'H:����� ���DsR�	�(�/A*�r�lp���h����,��Ae�4�$D���A2H��9s*DA:A4�O�{�>�A{���A� arF�D;Yb�6���-������M� t��`ib�F�b��F��3����c$F��4r�<0��#(�1�.�#M�4�6cS���(}#�Dcv��H�F�~�����������4�\�|�@c��@�#X�K��@�:�@���1���S�������=����4>� S�p?���6�ځ���5)l�q�a�OC�=����h�MH1�n���cx!3<h��a���j���+�
�@{��� �q��\��o�!��3pɸ��+U� s
�mh`2=|	���g�6V	P�M�k���P�H��ބhܺc3(&�4�֪��!^���U�^򚎢�'�xJ���y�Ɯ�;:�+^��G��㜧o�n��irk��?%jVo^�֎O++�_��(e��`O+�$Guh�5XEbi<��VA���$@M�Ї���AX3&3(Y͐�h��Fb5F�B�|� �60��d�n�7�0tΫ����!2� �U}t��E��
�|e�ǘ�� ��G)��^��V�r�vȤ�
E�c(L�eZ��"�e7ѹI)=�8��~r�9���~���� |֜ ��"2n�d4��2�b��V����JL�¡e8f�t�5��smqtds��u�Q ��ԖhD
ˆ�Yx�Ǟ#(�����˼��!�E-�)��ƴ�Ѧ��*@$AUU	e��i��͠*4�+4�)v�`�0���(�{_�(I���I9^�����5�"�@9��N-�n�J5Dc���K#��*�"�L��eR|j�р�w��+�I���T�p�\#I�T�;�J��H�H4m�)T�m��="M�_�u�H�}����(x�U�h$jB��_�Y]�2,��f����S.�t���jDej�E��G�0s6��Ӛ�ـg�+;�ht
��ʮ�B"<��`7�����e�N1k�杽;�������3
���Op�[��Ei	+Q�,����M
}�]�&��V��W�~l�cy�I�����{�a�5d�&(�|U-	�N�OXÎ(h)�݈���a�Y	q��J��%<�H�q��Q:,��C�S
�R���]ܯIX�BP��J=4��*oH6s�i�YMU|B���ԴH�S�s��k��?�6T#i��a�h �_�+��(�B����}r#�jz(Z
g;*��*6u)�G�N�*:Ve�pRY��Qйv��;��QŕG$H%�v�I��'�tF8�RP�:�H��&��s�yE������?�^EG�����+~��LSl)_�Q$>�<�UcMZ��~l+���x���I#��/�����Sr��n�y�X^+�U���~��`�Ϳ�|�9��V�ƘEcp,��%wrM\#*;o�Xi|l@42�p\�K�yc;�>���{�aD����/�*H/�@m��G	G��H.��z�c��TS� !�G��0XGU��H+���$j^��"�cҁf��Ur��j���*�2�7���^$TM���*�3M������Fci%��B�q��+�
�<AaOQ��T'B�Uc��n���F�c���,*@��SMS�.d�v�O0��c:��s%��~2:�T��Ӡ��5��ţ$�$͆X �X�����g��I~�(x�R���j6���.�+8x����(D����-(�pb��N�jF(BB\M�h2)Gp���u��+�f.DSMl�].��`����a�30Mߴ6�/ ����A�T���IޒBs���d&9#�c��*�!�|����X����ip [�������k��5 ê��1�qdi���Ʀ$
���mr���W��x"#�x��a�)2c��)��aH��MW �\�q��=+�$QQ���pmnh\���9�����i,X@ ��5*�+�.��� ��!sT�R�<���A��$7$��r ��6B[������]� ��  |\?�S����4�zU���E�V }`������m���n꘶o��@�[p1f���-UC���B@��Hy�jT!�$8Ɯ �Jq5:Q˷ȟ�.oF�X�(�3�x� �a�rF$7�\����Ý��ɲ�����˪K"���y+8����$ �3�W�����o����>�����W��M'����}�r��	��]a�g�p����JX���^��Bߔ,�h���
>X�'����1SFj"�BSz�i�Y>�^�����g�����m=��3϶�Z��aX��9�O6� Js��X���sF�������p1hՍJ��b����;b�";sh
��:k`9�{JᾗͰ��� �BO~?�����n�8S��ʲ�1DzkaMh��/�n����	���B��?��a0���$����;8`���`����� �  d�������������� ��������������z�������������k�gyhxwv�g���              �  �        � �     � 
       �   � ��
� 	 
       �       �	�    ���   ���� �
����� ��ze������pe��� ���ew���
��fv������e�������v�� ��  ���
                             <� !<�����@�R�J���#R�"Q%�����jQ8$D�0����1�� �"�I��0:�!��D����cڞ�А��)J� ��	J��4 m��ú��^�xϺ<��|�C��t�'|�!q�%[����X�E�C_��'������`_�a���%�ԋl�1� jPz8�,�TDP`�:~��,#���gP�!�d�����̌Ҷ8��a6�F���(�zP�`q��"��`#�&h�Jz*�A��J	I�*#��@���E�YO�+*����0$���z!BD�pbE�I�ă�BJ�l����9�`P���� YYΈW�� �"_�4ߕ#��)>Q�p#� �z�\a���p+��+��a1í��1�1�Ɩ����x����G�j����Y��wM�-�����
��$��q�L�񏐤60�a���Q�@>�X!M���!̂7J��b�n��p�,������Enß�̕���FN�t��T�]��kH�^YH���ᨀ�9|ɸ6�,�5����)|`���Mu�7"�$K����i�8r�:���̻�r\�sזu6�n���s-�:��UNr�̣�21��徨�r�p$?w����)g�b���6�i�:$J�h�a|jv9��:�,���#��r=�!~�*��[T�Ǆ�V��w�Uh���W-�U�e�i��@+�s"�۹y���N�.(��p"u��~�i�����l��
ֹj�b���"�AA+L�E��e]��,e9�n��x���9e�� $]��N�c��+&�Bs�b���fH+]I�0k�&�5t�_��06L�,�6��N�4�!N�V�c�J_I5����qk�&k&��gl۠��  ;dD���	����_�nء >7�Ap�. BC.R�H�6�P�%9qi�%�O��Gd��-�#sJ	�u�/1��"��'�F�@�Ui
�!�sX1jq�����W7�¾!w�iXTY5���8��1۵�x]ۜ���_��vOţ��AĘ{��H���:�"��G�U;]e���N$ɰlʆl���v��ڙ�E�,������p����>�����<���-��8L^�����͔���M�*.� >"� !SFZw�Yj�5cIN�i,I�ƒ|%F��#��/SZXv8�ט<oS	"�nL@������TTԸ��$����\6����R3��Qh�-�  �����#���y�F$�W(h#%1<������C�����ª��P>�G8|�sR� �5�PC� �G,�ۯ4&}1�}6��=J��,��7�0Vgjq��[Ԇ��eJ_ѕ�L��	�(4�c^��n̆S]�9�{&3LE0� �U0�Qs�I��7��ƝJ�CT�:��R��&�;����:4/����^T q z�>����zj���r�r�. �NJA��hN�$�G1.2�����iy�b2�y���%��h~ �c7���(�x|��]M���1wǬ��ƀ�t��&�H��E-��Qja��%���/��
��r�`�Q��Q�;�y�szD���~�++��eL�jnW�6k�9e�Y�q᥀YoT>� ���r�-B��U��	RM~�v$�Zw���~�Ό�v,�t0;�����z҈.{�M�QG��4�9	^�}-K!���3��YɈvF8M5�$�nHw�\�g�|F4���$R���� '���x���J�9SN�<YB�RFD���Ǆ����	�"P�����p�Cm�r@�2"ŬD���ʢ���d��I|b�:5�j&h��CP�ȡ$�[�Җ/�~����x��O2Y&B��O����T��Ğc75f�Q�; I�Rx3���u��JL�9�K�VD"7�=RH��*q�h"��ޘk�������K%پ��k�)���>Cȼ�^EEg�b�ܘ�B��)���B�Rɂm���m���e��� ��יi ��<�:<�[��@�m�9oL��x��Y%�wN��>�}o�;u����� ����c���P�ȇ�+�=�i��2��{݉�z�����6�2���gE��1D�Y�"*[�Oq*��/].%��51D��c�i?P_�Y0Ɛ����(�t�#v��0�KM�^�F�?�����$7�ֆ&�5q1�l�9\]@ú  f�{�����#"�c��1|�4����K���|rd��&�b�]j��%�Q�F2=o��/��` �UK�+��2ܷ��w�`��ҞJDJ��A41f��L�.�8��,{�+�ԉaԲmXB��;�B��~�!�p��9�Dnt(.:�u�$	J�/w�1�����\��?�����N5J@��yK�)]��#3[�,a���:�t� �U�a�=F�%��>Et�e���dE�b���f��)& #��G$8Jg_�E@�"�^��l�w|5��A�P�DR-Hw�s�OLH0�-��ˀ����f��(��,�*����P���'C�u�]�;n������0��h"��8��������D�<3���GAd��Lw�8�y'�	0>p|˲b��Cz�E�sGT ?�O6���ɑ�z��'Fh�8�ü8y{�j�1��9: B��S�Iu�t ��aj=#M�[sJ6�O���+��,��gZtlKnI1�x�m���ž�W���1v�4�3\�Ϙ`S�7z
iϠ�f��g����RD���jy[8��� �gVR(�.���! Z����$�ۖ5������I ��t�� �yQ-co#�oPU(��r:��kI�P,�hS�P�(L!;ȠpS���X3��x��q�<�VSxW� ���u�B�Z^x#*�T�h����MR�����nnV��jp��k�BcW�����Ua@����o4E1l� ������9BA��.�����8� ��)Jf qV��u�	4S�	n�j��kV+C<�R�}��@P����:�� �	 �bmVr��8 hD�JeH/�YEm�� ��-3�L��~fl4��/��K�ɋ��8x<]�J A#D��  � �jT�6(vv]��
s� �  vk    ��        Cache_Update_Frequency  ����y e s       ����y e s   �  ����vk    H�        Disable Script Debugger ����y e s       ����vk    ��        DisableScriptDebuggerIE ����y e s       ����n o     �  ���� �  ����vk    �        Display Inline Images   ����vk   �         Do404Search     ����n o     �  ����y e s   (�  ����vk
    P�        Local Page      ����% 1 1 % \ b l a n k . h t m         ����vk    ��        Save_Session_History_On_Exit    ����vk    �        Show_StatusBar  ����vk Z    �        Search Page     ����h t t p : / / g o . m i c r o s o f t . c o m / f w l i n k / ? L i n k I d = 5 4 8 9 6     ����vk    �        Show_FullURL    ����vk    (�        Show_URLinStatusBar ��  ����vk    ��        Show_ToolBar    ����y e s       ����vk    ��        Use_DlgBox_Colors�  ��  ���� �  ����y e s       ����vk    `�        Show_URLToolBar ����y e s       ����vk   �         XMLHTTP ����vk   �          height  ����y e s       ����vk    ��        UseClearType    ����n o         ������  ��  �  X�  ��  ��  (�  x�  ��  `�  ��  ��  ��  8�  ��  ��  p�  ����vk	    h�        Maximized       ����n o         ����(�  `�  ��  ����vk   �   �      width   ����vk   �   �      x       ������  @�  ��  ��  ��  ����vk   �          y       ����vk	   �         Completed       ����vk   �          RestrictImplicitInkCollection   ����vk   �          RestrictImplicitTextCollection  ����nk  3+�<��   H                               �                     0.0.0 ����      ��f��!�5�9�4Q��B   �          7  �����     �            � �� �                      E �                   �  �#          �           . �,          �           5   a �                   �  �#          �           . �,          �           � �r �                   �  �#      	    �           . �,      
    �           H �� �����   �          1  �1  �����   @           �  � �                  Q  �j  �                  �  �J   ����   �           1  �1  �����   �            �  � �                    �j  �����   �            \   �  �����   �            H �r   ����   �           1  �1  �����   @            �  � �                   Q  �j  �                   H �w   ����   �           1  �1  �����   @            �  � �                   Q  �j  �                   H ��   ����   �           1  �1  �����   @            �  � �                   Q  �j  �                   y �
 �                    �  �#      !    �           . �,      "    �            ��   ����#   @          1  �1  �����$               �  � �   %               . �j  �   &               � ��   ����'    �           1  �1  �����(    �            �  � �   )                  �j  �����*    �            H ��  �����+    �           1  �1  �����,   @            �  � �   -                Q  �j  �   .                y �
 �   /                 �  �#      0    �           . �,      1    �             ��      2    @            � ��      3    @            �  �#      4    �           . �,      5    �           H ��   ����6   �           1  �1  �����7   @            �  � �   8                Q  �j  �   9                H ��   ����:   �           1  �1  �����;   @            �  � �   <                Q  �j  �   =                H ��   ����>   �           1  �1  �����?   @            �  � �   @                Q  �j  �   A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ���G��܏Z56�:!@i�J*   �       �7  �����     �            � �� �                       E �                   �  �          �           . �          �           (   a �                   �  �          �           . �          �           � �r �                   �  �      	    �           . �      
    �           H �� �����   �          1  �1  �����   @           �  � �                  Q  �j  �                  H �� �����   �           1  �1  �����   @            �  � �                   Q  �j  �                   �  �=   ����   �           1  �1  �����   �            �  � �                    �j  �����   �            H ��  �����   �           1  �1  �����   @            �  � �                   Q  �j  �                   y �
 �                   �  �          �           . �          �           y �Q                       �  �          �           . �           �           �  �X      !                H �i   ����"   �           1  �1  �����#   @            �  � �   $                Q  �j  �   %                H �u   ����&   �           1  �1  �����'   @            �  � �   (                Q  �j  �   )              PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                        \       �y�     `       �                                                                                                                                                �y�                                                                                    StickyNoteOption4  namespace Unity.VisualScripting
{
    public sealed class StickyNoteOption : FuzzyOption<object>
    {
        public StickyNoteOption()
        {
            label = "Sticky Note";
            value = typeof(StickyNote);
            UnityAPI.Async(() => icon = typeof(StickyNote).Icon());
        }
    }
}
