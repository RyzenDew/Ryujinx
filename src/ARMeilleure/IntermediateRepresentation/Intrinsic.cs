using System;
using System.Diagnostics.CodeAnalysis;

namespace ARMeilleure.IntermediateRepresentation
{
    [Flags]
    [SuppressMessage("Design", "CA1069: Enums values should not be duplicated")]
    enum Intrinsic : ushort
    {
        // X86 (SSE and AVX)

        X86Addpd,
        X86Addps,
        X86Addsd,
        X86Addss,
        X86Aesdec,
        X86Aesdeclast,
        X86Aesenc,
        X86Aesenclast,
        X86Aesimc,
        X86Andnpd,
        X86Andnps,
        X86Andpd,
        X86Andps,
        X86Blendvpd,
        X86Blendvps,
        X86Cmppd,
        X86Cmpps,
        X86Cmpsd,
        X86Cmpss,
        X86Comisdeq,
        X86Comisdge,
        X86Comisdlt,
        X86Comisseq,
        X86Comissge,
        X86Comisslt,
        X86Crc32,
        X86Crc32_16,
        X86Crc32_8,
        X86Cvtdq2pd,
        X86Cvtdq2ps,
        X86Cvtpd2dq,
        X86Cvtpd2ps,
        X86Cvtps2dq,
        X86Cvtps2pd,
        X86Cvtsd2si,
        X86Cvtsd2ss,
        X86Cvtsi2sd,
        X86Cvtsi2si,
        X86Cvtsi2ss,
        X86Cvtss2sd,
        X86Cvtss2si,
        X86Divpd,
        X86Divps,
        X86Divsd,
        X86Divss,
        X86Gf2p8affineqb,
        X86Haddpd,
        X86Haddps,
        X86Insertps,
        X86Ldmxcsr,
        X86Maxpd,
        X86Maxps,
        X86Maxsd,
        X86Maxss,
        X86Minpd,
        X86Minps,
        X86Minsd,
        X86Minss,
        X86Movhlps,
        X86Movlhps,
        X86Movss,
        X86Mulpd,
        X86Mulps,
        X86Mulsd,
        X86Mulss,
        X86Paddb,
        X86Paddd,
        X86Paddq,
        X86Paddw,
        X86Palignr,
        X86Pand,
        X86Pandn,
        X86Pavgb,
        X86Pavgw,
        X86Pblendvb,
        X86Pclmulqdq,
        X86Pcmpeqb,
        X86Pcmpeqd,
        X86Pcmpeqq,
        X86Pcmpeqw,
        X86Pcmpgtb,
        X86Pcmpgtd,
        X86Pcmpgtq,
        X86Pcmpgtw,
        X86Pmaxsb,
        X86Pmaxsd,
        X86Pmaxsw,
        X86Pmaxub,
        X86Pmaxud,
        X86Pmaxuw,
        X86Pminsb,
        X86Pminsd,
        X86Pminsw,
        X86Pminub,
        X86Pminud,
        X86Pminuw,
        X86Pmovsxbw,
        X86Pmovsxdq,
        X86Pmovsxwd,
        X86Pmovzxbw,
        X86Pmovzxdq,
        X86Pmovzxwd,
        X86Pmulld,
        X86Pmullw,
        X86Popcnt,
        X86Por,
        X86Pshufb,
        X86Pshufd,
        X86Pslld,
        X86Pslldq,
        X86Psllq,
        X86Psllw,
        X86Psrad,
        X86Psraw,
        X86Psrld,
        X86Psrlq,
        X86Psrldq,
        X86Psrlw,
        X86Psubb,
        X86Psubd,
        X86Psubq,
        X86Psubw,
        X86Punpckhbw,
        X86Punpckhdq,
        X86Punpckhqdq,
        X86Punpckhwd,
        X86Punpcklbw,
        X86Punpckldq,
        X86Punpcklqdq,
        X86Punpcklwd,
        X86Pxor,
        X86Rcpps,
        X86Rcpss,
        X86Roundpd,
        X86Roundps,
        X86Roundsd,
        X86Roundss,
        X86Rsqrtps,
        X86Rsqrtss,
        X86Sha256Msg1,
        X86Sha256Msg2,
        X86Sha256Rnds2,
        X86Shufpd,
        X86Shufps,
        X86Sqrtpd,
        X86Sqrtps,
        X86Sqrtsd,
        X86Sqrtss,
        X86Stmxcsr,
        X86Subpd,
        X86Subps,
        X86Subsd,
        X86Subss,
        X86Unpckhpd,
        X86Unpckhps,
        X86Unpcklpd,
        X86Unpcklps,
        X86Vcvtph2ps,
        X86Vcvtps2ph,
        X86Vfmadd231pd,
        X86Vfmadd231ps,
        X86Vfmadd231sd,
        X86Vfmadd231ss,
        X86Vfmsub231sd,
        X86Vfmsub231ss,
        X86Vfnmadd231pd,
        X86Vfnmadd231ps,
        X86Vfnmadd231sd,
        X86Vfnmadd231ss,
        X86Vfnmsub231sd,
        X86Vfnmsub231ss,
        X86Vpternlogd,
        X86Xorpd,
        X86Xorps,

        // Arm64 (FP and Advanced SIMD)

        Arm64AbsS,
        Arm64AbsV,
        Arm64AddhnV,
        Arm64AddpS,
        Arm64AddpV,
        Arm64AddvV,
        Arm64AddS,
        Arm64AddV,
        Arm64AesdV,
        Arm64AeseV,
        Arm64AesimcV,
        Arm64AesmcV,
        Arm64AndV,
        Arm64BicVi,
        Arm64BicV,
        Arm64BifV,
        Arm64BitV,
        Arm64BslV,
        Arm64ClsV,
        Arm64ClzV,
        Arm64CmeqS,
        Arm64CmeqV,
        Arm64CmeqSz,
        Arm64CmeqVz,
        Arm64CmgeS,
        Arm64CmgeV,
        Arm64CmgeSz,
        Arm64CmgeVz,
        Arm64CmgtS,
        Arm64CmgtV,
        Arm64CmgtSz,
        Arm64CmgtVz,
        Arm64CmhiS,
        Arm64CmhiV,
        Arm64CmhsS,
        Arm64CmhsV,
        Arm64CmleSz,
        Arm64CmleVz,
        Arm64CmltSz,
        Arm64CmltVz,
        Arm64CmtstS,
        Arm64CmtstV,
        Arm64CntV,
        Arm64DupSe,
        Arm64DupVe,
        Arm64DupGp,
        Arm64EorV,
        Arm64ExtV,
        Arm64FabdS,
        Arm64FabdV,
        Arm64FabsV,
        Arm64FabsS,
        Arm64FacgeS,
        Arm64FacgeV,
        Arm64FacgtS,
        Arm64FacgtV,
        Arm64FaddpS,
        Arm64FaddpV,
        Arm64FaddV,
        Arm64FaddS,
        Arm64FccmpeS,
        Arm64FccmpS,
        Arm64FcmeqS,
        Arm64FcmeqV,
        Arm64FcmeqSz,
        Arm64FcmeqVz,
        Arm64FcmgeS,
        Arm64FcmgeV,
        Arm64FcmgeSz,
        Arm64FcmgeVz,
        Arm64FcmgtS,
        Arm64FcmgtV,
        Arm64FcmgtSz,
        Arm64FcmgtVz,
        Arm64FcmleSz,
        Arm64FcmleVz,
        Arm64FcmltSz,
        Arm64FcmltVz,
        Arm64FcmpeS,
        Arm64FcmpS,
        Arm64FcselS,
        Arm64FcvtasS,
        Arm64FcvtasV,
        Arm64FcvtasGp,
        Arm64FcvtauS,
        Arm64FcvtauV,
        Arm64FcvtauGp,
        Arm64FcvtlV,
        Arm64FcvtmsS,
        Arm64FcvtmsV,
        Arm64FcvtmsGp,
        Arm64FcvtmuS,
        Arm64FcvtmuV,
        Arm64FcvtmuGp,
        Arm64FcvtnsS,
        Arm64FcvtnsV,
        Arm64FcvtnsGp,
        Arm64FcvtnuS,
        Arm64FcvtnuV,
        Arm64FcvtnuGp,
        Arm64FcvtnV,
        Arm64FcvtpsS,
        Arm64FcvtpsV,
        Arm64FcvtpsGp,
        Arm64FcvtpuS,
        Arm64FcvtpuV,
        Arm64FcvtpuGp,
        Arm64FcvtxnS,
        Arm64FcvtxnV,
        Arm64FcvtzsSFixed,
        Arm64FcvtzsVFixed,
        Arm64FcvtzsS,
        Arm64FcvtzsV,
        Arm64FcvtzsGpFixed,
        Arm64FcvtzsGp,
        Arm64FcvtzuSFixed,
        Arm64FcvtzuVFixed,
        Arm64FcvtzuS,
        Arm64FcvtzuV,
        Arm64FcvtzuGpFixed,
        Arm64FcvtzuGp,
        Arm64FcvtS,
        Arm64FdivV,
        Arm64FdivS,
        Arm64FmaddS,
        Arm64FmaxnmpS,
        Arm64FmaxnmpV,
        Arm64FmaxnmvV,
        Arm64FmaxnmV,
        Arm64FmaxnmS,
        Arm64FmaxpS,
        Arm64FmaxpV,
        Arm64FmaxvV,
        Arm64FmaxV,
        Arm64FmaxS,
        Arm64FminnmpS,
        Arm64FminnmpV,
        Arm64FminnmvV,
        Arm64FminnmV,
        Arm64FminnmS,
        Arm64FminpS,
        Arm64FminpV,
        Arm64FminvV,
        Arm64FminV,
        Arm64FminS,
        Arm64FmlaSe,
        Arm64FmlaVe,
        Arm64FmlaV,
        Arm64FmlsSe,
        Arm64FmlsVe,
        Arm64FmlsV,
        Arm64FmovVi,
        Arm64FmovS,
        Arm64FmovGp,
        Arm64FmovSi,
        Arm64FmsubS,
        Arm64FmulxSe,
        Arm64FmulxVe,
        Arm64FmulxS,
        Arm64FmulxV,
        Arm64FmulSe,
        Arm64FmulVe,
        Arm64FmulV,
        Arm64FmulS,
        Arm64FnegV,
        Arm64FnegS,
        Arm64FnmaddS,
        Arm64FnmsubS,
        Arm64FnmulS,
        Arm64FrecpeS,
        Arm64FrecpeV,
        Arm64FrecpsS,
        Arm64FrecpsV,
        Arm64FrecpxS,
        Arm64FrintaV,
        Arm64FrintaS,
        Arm64FrintiV,
        Arm64FrintiS,
        Arm64FrintmV,
        Arm64FrintmS,
        Arm64FrintnV,
        Arm64FrintnS,
        Arm64FrintpV,
        Arm64FrintpS,
        Arm64FrintxV,
        Arm64FrintxS,
        Arm64FrintzV,
        Arm64FrintzS,
        Arm64FrsqrteS,
        Arm64FrsqrteV,
        Arm64FrsqrtsS,
        Arm64FrsqrtsV,
        Arm64FsqrtV,
        Arm64FsqrtS,
        Arm64FsubV,
        Arm64FsubS,
        Arm64InsVe,
        Arm64InsGp,
        Arm64Ld1rV,
        Arm64Ld1Vms,
        Arm64Ld1Vss,
        Arm64Ld2rV,
        Arm64Ld2Vms,
        Arm64Ld2Vss,
        Arm64Ld3rV,
        Arm64Ld3Vms,
        Arm64Ld3Vss,
        Arm64Ld4rV,
        Arm64Ld4Vms,
        Arm64Ld4Vss,
        Arm64MlaVe,
        Arm64MlaV,
        Arm64MlsVe,
        Arm64MlsV,
        Arm64MoviV,
        Arm64MrsFpcr,
        Arm64MsrFpcr,
        Arm64MrsFpsr,
        Arm64MsrFpsr,
        Arm64MulVe,
        Arm64MulV,
        Arm64MvniV,
        Arm64NegS,
        Arm64NegV,
        Arm64NotV,
        Arm64OrnV,
        Arm64OrrVi,
        Arm64OrrV,
        Arm64PmullV,
        Arm64PmulV,
        Arm64RaddhnV,
        Arm64RbitV,
        Arm64Rev16V,
        Arm64Rev32V,
        Arm64Rev64V,
        Arm64RshrnV,
        Arm64RsubhnV,
        Arm64SabalV,
        Arm64SabaV,
        Arm64SabdlV,
        Arm64SabdV,
        Arm64SadalpV,
        Arm64SaddlpV,
        Arm64SaddlvV,
        Arm64SaddlV,
        Arm64SaddwV,
        Arm64ScvtfSFixed,
        Arm64ScvtfVFixed,
        Arm64ScvtfS,
        Arm64ScvtfV,
        Arm64ScvtfGpFixed,
        Arm64ScvtfGp,
        Arm64Sha1cV,
        Arm64Sha1hV,
        Arm64Sha1mV,
        Arm64Sha1pV,
        Arm64Sha1su0V,
        Arm64Sha1su1V,
        Arm64Sha256h2V,
        Arm64Sha256hV,
        Arm64Sha256su0V,
        Arm64Sha256su1V,
        Arm64ShaddV,
        Arm64ShllV,
        Arm64ShlS,
        Arm64ShlV,
        Arm64ShrnV,
        Arm64ShsubV,
        Arm64SliS,
        Arm64SliV,
        Arm64SmaxpV,
        Arm64SmaxvV,
        Arm64SmaxV,
        Arm64SminpV,
        Arm64SminvV,
        Arm64SminV,
        Arm64SmlalVe,
        Arm64SmlalV,
        Arm64SmlslVe,
        Arm64SmlslV,
        Arm64SmovV,
        Arm64SmullVe,
        Arm64SmullV,
        Arm64SqabsS,
        Arm64SqabsV,
        Arm64SqaddS,
        Arm64SqaddV,
        Arm64SqdmlalSe,
        Arm64SqdmlalVe,
        Arm64SqdmlalS,
        Arm64SqdmlalV,
        Arm64SqdmlslSe,
        Arm64SqdmlslVe,
        Arm64SqdmlslS,
        Arm64SqdmlslV,
        Arm64SqdmulhSe,
        Arm64SqdmulhVe,
        Arm64SqdmulhS,
        Arm64SqdmulhV,
        Arm64SqdmullSe,
        Arm64SqdmullVe,
        Arm64SqdmullS,
        Arm64SqdmullV,
        Arm64SqnegS,
        Arm64SqnegV,
        Arm64SqrdmulhSe,
        Arm64SqrdmulhVe,
        Arm64SqrdmulhS,
        Arm64SqrdmulhV,
        Arm64SqrshlS,
        Arm64SqrshlV,
        Arm64SqrshrnS,
        Arm64SqrshrnV,
        Arm64SqrshrunS,
        Arm64SqrshrunV,
        Arm64SqshluS,
        Arm64SqshluV,
        Arm64SqshlSi,
        Arm64SqshlVi,
        Arm64SqshlS,
        Arm64SqshlV,
        Arm64SqshrnS,
        Arm64SqshrnV,
        Arm64SqshrunS,
        Arm64SqshrunV,
        Arm64SqsubS,
        Arm64SqsubV,
        Arm64SqxtnS,
        Arm64SqxtnV,
        Arm64SqxtunS,
        Arm64SqxtunV,
        Arm64SrhaddV,
        Arm64SriS,
        Arm64SriV,
        Arm64SrshlS,
        Arm64SrshlV,
        Arm64SrshrS,
        Arm64SrshrV,
        Arm64SrsraS,
        Arm64SrsraV,
        Arm64SshllV,
        Arm64SshlS,
        Arm64SshlV,
        Arm64SshrS,
        Arm64SshrV,
        Arm64SsraS,
        Arm64SsraV,
        Arm64SsublV,
        Arm64SsubwV,
        Arm64St1Vms,
        Arm64St1Vss,
        Arm64St2Vms,
        Arm64St2Vss,
        Arm64St3Vms,
        Arm64St3Vss,
        Arm64St4Vms,
        Arm64St4Vss,
        Arm64SubhnV,
        Arm64SubS,
        Arm64SubV,
        Arm64SuqaddS,
        Arm64SuqaddV,
        Arm64TblV,
        Arm64TbxV,
        Arm64Trn1V,
        Arm64Trn2V,
        Arm64UabalV,
        Arm64UabaV,
        Arm64UabdlV,
        Arm64UabdV,
        Arm64UadalpV,
        Arm64UaddlpV,
        Arm64UaddlvV,
        Arm64UaddlV,
        Arm64UaddwV,
        Arm64UcvtfSFixed,
        Arm64UcvtfVFixed,
        Arm64UcvtfS,
        Arm64UcvtfV,
        Arm64UcvtfGpFixed,
        Arm64UcvtfGp,
        Arm64UhaddV,
        Arm64UhsubV,
        Arm64UmaxpV,
        Arm64UmaxvV,
        Arm64UmaxV,
        Arm64UminpV,
        Arm64UminvV,
        Arm64UminV,
        Arm64UmlalVe,
        Arm64UmlalV,
        Arm64UmlslVe,
        Arm64UmlslV,
        Arm64UmovV,
        Arm64UmullVe,
        Arm64UmullV,
        Arm64UqaddS,
        Arm64UqaddV,
        Arm64UqrshlS,
        Arm64UqrshlV,
        Arm64UqrshrnS,
        Arm64UqrshrnV,
        Arm64UqshlSi,
        Arm64UqshlVi,
        Arm64UqshlS,
        Arm64UqshlV,
        Arm64UqshrnS,
        Arm64UqshrnV,
        Arm64UqsubS,
        Arm64UqsubV,
        Arm64UqxtnS,
        Arm64UqxtnV,
        Arm64UrecpeV,
        Arm64UrhaddV,
        Arm64UrshlS,
        Arm64UrshlV,
        Arm64UrshrS,
        Arm64UrshrV,
        Arm64UrsqrteV,
        Arm64UrsraS,
        Arm64UrsraV,
        Arm64UshllV,
        Arm64UshlS,
        Arm64UshlV,
        Arm64UshrS,
        Arm64UshrV,
        Arm64UsqaddS,
        Arm64UsqaddV,
        Arm64UsraS,
        Arm64UsraV,
        Arm64UsublV,
        Arm64UsubwV,
        Arm64Uzp1V,
        Arm64Uzp2V,
        Arm64XtnV,
        Arm64Zip1V,
        Arm64Zip2V,

        Arm64VTypeShift = 13,
        Arm64VTypeMask = 1 << Arm64VTypeShift,
        Arm64V64 = 0 << Arm64VTypeShift,
        Arm64V128 = 1 << Arm64VTypeShift,

        Arm64VSizeShift = 14,
        Arm64VSizeMask = 3 << Arm64VSizeShift,
        Arm64VFloat = 0 << Arm64VSizeShift,
        Arm64VDouble = 1 << Arm64VSizeShift,
        Arm64VByte = 0 << Arm64VSizeShift,
        Arm64VHWord = 1 << Arm64VSizeShift,
        Arm64VWord = 2 << Arm64VSizeShift,
        Arm64VDWord = 3 << Arm64VSizeShift,
    }
}
