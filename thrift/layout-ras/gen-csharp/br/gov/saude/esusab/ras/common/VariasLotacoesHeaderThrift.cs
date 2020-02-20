/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esusab.ras.common
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class VariasLotacoesHeaderThrift : TBase
  {
    private LotacaoHeaderThrift _lotacaoFormPrincipal;
    private LotacaoHeaderThrift _lotacaoFormAtendimentoCompartilhado;
    private long _dataAtendimento;
    private string _codigoIbgeMunicipio;

    public LotacaoHeaderThrift LotacaoFormPrincipal
    {
      get
      {
        return _lotacaoFormPrincipal;
      }
      set
      {
        __isset.lotacaoFormPrincipal = true;
        this._lotacaoFormPrincipal = value;
      }
    }

    public LotacaoHeaderThrift LotacaoFormAtendimentoCompartilhado
    {
      get
      {
        return _lotacaoFormAtendimentoCompartilhado;
      }
      set
      {
        __isset.lotacaoFormAtendimentoCompartilhado = true;
        this._lotacaoFormAtendimentoCompartilhado = value;
      }
    }

    public long DataAtendimento
    {
      get
      {
        return _dataAtendimento;
      }
      set
      {
        __isset.dataAtendimento = true;
        this._dataAtendimento = value;
      }
    }

    public string CodigoIbgeMunicipio
    {
      get
      {
        return _codigoIbgeMunicipio;
      }
      set
      {
        __isset.codigoIbgeMunicipio = true;
        this._codigoIbgeMunicipio = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool lotacaoFormPrincipal;
      public bool lotacaoFormAtendimentoCompartilhado;
      public bool dataAtendimento;
      public bool codigoIbgeMunicipio;
    }

    public VariasLotacoesHeaderThrift() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 6:
              if (field.Type == TType.Struct) {
                LotacaoFormPrincipal = new LotacaoHeaderThrift();
                LotacaoFormPrincipal.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Struct) {
                LotacaoFormAtendimentoCompartilhado = new LotacaoHeaderThrift();
                LotacaoFormAtendimentoCompartilhado.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I64) {
                DataAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.String) {
                CodigoIbgeMunicipio = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("VariasLotacoesHeaderThrift");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (LotacaoFormPrincipal != null && __isset.lotacaoFormPrincipal) {
          field.Name = "lotacaoFormPrincipal";
          field.Type = TType.Struct;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          LotacaoFormPrincipal.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (LotacaoFormAtendimentoCompartilhado != null && __isset.lotacaoFormAtendimentoCompartilhado) {
          field.Name = "lotacaoFormAtendimentoCompartilhado";
          field.Type = TType.Struct;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          LotacaoFormAtendimentoCompartilhado.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataAtendimento) {
          field.Name = "dataAtendimento";
          field.Type = TType.I64;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataAtendimento);
          oprot.WriteFieldEnd();
        }
        if (CodigoIbgeMunicipio != null && __isset.codigoIbgeMunicipio) {
          field.Name = "codigoIbgeMunicipio";
          field.Type = TType.String;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CodigoIbgeMunicipio);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("VariasLotacoesHeaderThrift(");
      bool __first = true;
      if (LotacaoFormPrincipal != null && __isset.lotacaoFormPrincipal) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LotacaoFormPrincipal: ");
        __sb.Append(LotacaoFormPrincipal== null ? "<null>" : LotacaoFormPrincipal.ToString());
      }
      if (LotacaoFormAtendimentoCompartilhado != null && __isset.lotacaoFormAtendimentoCompartilhado) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LotacaoFormAtendimentoCompartilhado: ");
        __sb.Append(LotacaoFormAtendimentoCompartilhado== null ? "<null>" : LotacaoFormAtendimentoCompartilhado.ToString());
      }
      if (__isset.dataAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DataAtendimento: ");
        __sb.Append(DataAtendimento);
      }
      if (CodigoIbgeMunicipio != null && __isset.codigoIbgeMunicipio) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CodigoIbgeMunicipio: ");
        __sb.Append(CodigoIbgeMunicipio);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}