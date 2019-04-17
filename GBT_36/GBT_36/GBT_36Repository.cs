﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace GBT_36
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the GBT_36Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("c81240ae-7b55-4acf-9fae-5cbae3a93ded")]
    public partial class GBT_36Repository : RepoGenBaseFolder
    {
        static GBT_36Repository instance = new GBT_36Repository();
        GBT_36RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        GBT_36RepositoryFolders.HọcLiệuSachMềmAppFolder _họcliệusachmềm;

        /// <summary>
        /// Gets the singleton class instance representing the GBT_36Repository element repository.
        /// </summary>
        [RepositoryFolder("c81240ae-7b55-4acf-9fae-5cbae3a93ded")]
        public static GBT_36Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public GBT_36Repository() 
            : base("GBT_36Repository", "/", null, 0, false, "c81240ae-7b55-4acf-9fae-5cbae3a93ded", ".\\RepositoryImages\\GBT_36Repositoryc81240ae.rximgres")
        {
            _applicationundertest = new GBT_36RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _họcliệusachmềm = new GBT_36RepositoryFolders.HọcLiệuSachMềmAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c81240ae-7b55-4acf-9fae-5cbae3a93ded")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("cfaf14c8-0706-4ec2-a8f2-9e3bd850c45f")]
        public virtual GBT_36RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The HọcLiệuSachMềm folder.
        /// </summary>
        [RepositoryFolder("ccea4cf8-d934-469e-8566-4949a45b3cfe")]
        public virtual GBT_36RepositoryFolders.HọcLiệuSachMềmAppFolder HọcLiệuSachMềm
        {
            get { return _họcliệusachmềm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class GBT_36RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("cfaf14c8-0706-4ec2-a8f2-9e3bd850c45f")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, true, "cfaf14c8-0706-4ec2-a8f2-9e3bd850c45f", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cfaf14c8-0706-4ec2-a8f2-9e3bd850c45f")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cfaf14c8-0706-4ec2-a8f2-9e3bd850c45f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The HọcLiệuSachMềmAppFolder folder.
        /// </summary>
        [RepositoryFolder("ccea4cf8-d934-469e-8566-4949a45b3cfe")]
        public partial class HọcLiệuSachMềmAppFolder : RepoGenBaseFolder
        {
            GBT_36RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder _httpshoclieusachmemvnquestionset;
            RepoItemInfo _giaobaitậpInfo;
            RepoItemInfo _divtaggiaobaitậpthanhcongInfo;

            /// <summary>
            /// Creates a new HọcLiệuSachMềm  folder.
            /// </summary>
            public HọcLiệuSachMềmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("HọcLiệuSachMềm", "/dom[@domain='hoclieu.sachmem.vn']", parentFolder, 30000, null, false, "ccea4cf8-d934-469e-8566-4949a45b3cfe", "")
            {
                _httpshoclieusachmemvnquestionset = new GBT_36RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder(this);
                _giaobaitậpInfo = new RepoItemInfo(this, "GiaoBaiTập", "body/tag[@tagname='app-root']/div[2]//tag[@tagname='question']/div/div[2]/div/?/?/tag[@tagname='app-preview-list-question']/div/div[1]/div[1]/div[2]/a[@href='javascript:void(0)']/span[@innertext='Giao bài tập']", 30000, null, "8f3a42d5-9ffa-43df-8be2-53855d302b98");
                _divtaggiaobaitậpthanhcongInfo = new RepoItemInfo(this, "DivTagGiaoBaiTậpThanhCong", ".//div[#'toast-container']/?/?/div[@innertext=' Giao bài tập thành công ']", 30000, null, "0360ea97-3235-446e-b99a-46d22e27080a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ccea4cf8-d934-469e-8566-4949a45b3cfe")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ccea4cf8-d934-469e-8566-4949a45b3cfe")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The GiaoBaiTập item.
            /// </summary>
            [RepositoryItem("8f3a42d5-9ffa-43df-8be2-53855d302b98")]
            public virtual Ranorex.SpanTag GiaoBaiTập
            {
                get
                {
                    return _giaobaitậpInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The GiaoBaiTập item info.
            /// </summary>
            [RepositoryItemInfo("8f3a42d5-9ffa-43df-8be2-53855d302b98")]
            public virtual RepoItemInfo GiaoBaiTậpInfo
            {
                get
                {
                    return _giaobaitậpInfo;
                }
            }

            /// <summary>
            /// The DivTagGiaoBaiTậpThanhCong item.
            /// </summary>
            [RepositoryItem("0360ea97-3235-446e-b99a-46d22e27080a")]
            public virtual Ranorex.DivTag DivTagGiaoBaiTậpThanhCong
            {
                get
                {
                    return _divtaggiaobaitậpthanhcongInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagGiaoBaiTậpThanhCong item info.
            /// </summary>
            [RepositoryItemInfo("0360ea97-3235-446e-b99a-46d22e27080a")]
            public virtual RepoItemInfo DivTagGiaoBaiTậpThanhCongInfo
            {
                get
                {
                    return _divtaggiaobaitậpthanhcongInfo;
                }
            }

            /// <summary>
            /// The HttpsHoclieuSachmemVnQuestionSet folder.
            /// </summary>
            [RepositoryFolder("039fd47a-b97b-4571-9de0-dd7c405f1afe")]
            public virtual GBT_36RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder HttpsHoclieuSachmemVnQuestionSet
            {
                get { return _httpshoclieusachmemvnquestionset; }
            }
        }

        /// <summary>
        /// The HttpsHoclieuSachmemVnQuestionSetFolder folder.
        /// </summary>
        [RepositoryFolder("039fd47a-b97b-4571-9de0-dd7c405f1afe")]
        public partial class HttpsHoclieuSachmemVnQuestionSetFolder : RepoGenBaseFolder
        {
            RepoItemInfo _submitInfo;
            RepoItemInfo _modalbodyInfo;
            RepoItemInfo _divtagrowInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _ngarrowwrapperInfo;
            RepoItemInfo _ngoptionngoptionmarkedInfo;
            RepoItemInfo _numberInfo;
            RepoItemInfo _number1Info;

            /// <summary>
            /// Creates a new HttpsHoclieuSachmemVnQuestionSet  folder.
            /// </summary>
            public HttpsHoclieuSachmemVnQuestionSetFolder(RepoGenBaseFolder parentFolder) :
                    base("HttpsHoclieuSachmemVnQuestionSet", ".//div[#'createAssignmentModal']//form[@action='https://hoclieu.sachmem.vn/question_set/5a4b18bc48150cd8b90657e7/5a4b18bc48150cd8b90657ea/preview']", parentFolder, 30000, null, false, "039fd47a-b97b-4571-9de0-dd7c405f1afe", "")
            {
                _submitInfo = new RepoItemInfo(this, "Submit", "?/?/input[@type='submit']", 30000, null, "fbaffcdc-c0c8-42d8-b114-91275a178dd1");
                _modalbodyInfo = new RepoItemInfo(this, "ModalBody", "div[1]", 30000, null, "1c1deb2c-eef8-4d2d-858d-166040016362");
                _divtagrowInfo = new RepoItemInfo(this, "DivTagRow", "div[1]/div[10]", 30000, null, "26715131-42e5-47f4-b7e5-c1fa42ba9843");
                _textInfo = new RepoItemInfo(this, "Text", "div[1]/div[2]/input[@type='text']", 30000, null, "477f1406-4d5b-4089-b2d0-0550caadd6ba");
                _ngarrowwrapperInfo = new RepoItemInfo(this, "NgArrowWrapper", "div[1]/div[3]//span", 30000, null, "5ba5268c-4920-4fd7-892b-aaf4d8a1bfe7");
                _ngoptionngoptionmarkedInfo = new RepoItemInfo(this, "NgOptionNgOptionMarked", "div[1]/div[3]/?/?/tag[@tagname='ng-dropdown-panel']/div/div[2]/div", 30000, null, "1e0e7942-d9cc-46e8-95a8-94fc68620950");
                _numberInfo = new RepoItemInfo(this, "Number", "div[1]/div[6]/input[@type='number']", 30000, null, "7be354a1-681d-4f86-908e-c622d0c0b5fa");
                _number1Info = new RepoItemInfo(this, "Number1", "div[1]/div[7]/input[@type='number']", 30000, null, "03e898e6-486e-4f8e-92b3-10ab3a592f18");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("039fd47a-b97b-4571-9de0-dd7c405f1afe")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("039fd47a-b97b-4571-9de0-dd7c405f1afe")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("fbaffcdc-c0c8-42d8-b114-91275a178dd1")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("fbaffcdc-c0c8-42d8-b114-91275a178dd1")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }

            /// <summary>
            /// The ModalBody item.
            /// </summary>
            [RepositoryItem("1c1deb2c-eef8-4d2d-858d-166040016362")]
            public virtual Ranorex.DivTag ModalBody
            {
                get
                {
                    return _modalbodyInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The ModalBody item info.
            /// </summary>
            [RepositoryItemInfo("1c1deb2c-eef8-4d2d-858d-166040016362")]
            public virtual RepoItemInfo ModalBodyInfo
            {
                get
                {
                    return _modalbodyInfo;
                }
            }

            /// <summary>
            /// The DivTagRow item.
            /// </summary>
            [RepositoryItem("26715131-42e5-47f4-b7e5-c1fa42ba9843")]
            public virtual Ranorex.DivTag DivTagRow
            {
                get
                {
                    return _divtagrowInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagRow item info.
            /// </summary>
            [RepositoryItemInfo("26715131-42e5-47f4-b7e5-c1fa42ba9843")]
            public virtual RepoItemInfo DivTagRowInfo
            {
                get
                {
                    return _divtagrowInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("477f1406-4d5b-4089-b2d0-0550caadd6ba")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("477f1406-4d5b-4089-b2d0-0550caadd6ba")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The NgArrowWrapper item.
            /// </summary>
            [RepositoryItem("5ba5268c-4920-4fd7-892b-aaf4d8a1bfe7")]
            public virtual Ranorex.SpanTag NgArrowWrapper
            {
                get
                {
                    return _ngarrowwrapperInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The NgArrowWrapper item info.
            /// </summary>
            [RepositoryItemInfo("5ba5268c-4920-4fd7-892b-aaf4d8a1bfe7")]
            public virtual RepoItemInfo NgArrowWrapperInfo
            {
                get
                {
                    return _ngarrowwrapperInfo;
                }
            }

            /// <summary>
            /// The NgOptionNgOptionMarked item.
            /// </summary>
            [RepositoryItem("1e0e7942-d9cc-46e8-95a8-94fc68620950")]
            public virtual Ranorex.DivTag NgOptionNgOptionMarked
            {
                get
                {
                    return _ngoptionngoptionmarkedInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The NgOptionNgOptionMarked item info.
            /// </summary>
            [RepositoryItemInfo("1e0e7942-d9cc-46e8-95a8-94fc68620950")]
            public virtual RepoItemInfo NgOptionNgOptionMarkedInfo
            {
                get
                {
                    return _ngoptionngoptionmarkedInfo;
                }
            }

            /// <summary>
            /// The Number item.
            /// </summary>
            [RepositoryItem("7be354a1-681d-4f86-908e-c622d0c0b5fa")]
            public virtual Ranorex.InputTag Number
            {
                get
                {
                    return _numberInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Number item info.
            /// </summary>
            [RepositoryItemInfo("7be354a1-681d-4f86-908e-c622d0c0b5fa")]
            public virtual RepoItemInfo NumberInfo
            {
                get
                {
                    return _numberInfo;
                }
            }

            /// <summary>
            /// The Number1 item.
            /// </summary>
            [RepositoryItem("03e898e6-486e-4f8e-92b3-10ab3a592f18")]
            public virtual Ranorex.InputTag Number1
            {
                get
                {
                    return _number1Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Number1 item info.
            /// </summary>
            [RepositoryItemInfo("03e898e6-486e-4f8e-92b3-10ab3a592f18")]
            public virtual RepoItemInfo Number1Info
            {
                get
                {
                    return _number1Info;
                }
            }
        }

    }
#pragma warning restore 0436
}