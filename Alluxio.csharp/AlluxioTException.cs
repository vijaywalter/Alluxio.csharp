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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class AlluxioTException : TException, TBase
{
  private string _type;
  private string _message;
  private string _className;

  public string Type
  {
    get
    {
      return _type;
    }
    set
    {
      __isset.type = true;
      this._type = value;
    }
  }

  public string Message
  {
    get
    {
      return _message;
    }
    set
    {
      __isset.message = true;
      this._message = value;
    }
  }

  public string ClassName
  {
    get
    {
      return _className;
    }
    set
    {
      __isset.className = true;
      this._className = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool type;
    public bool message;
    public bool className;
  }

  public AlluxioTException() {
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
          case 1:
            if (field.Type == TType.String) {
              Type = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Message = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              ClassName = iprot.ReadString();
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
      TStruct struc = new TStruct("AlluxioTException");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Type != null && __isset.type) {
        field.Name = "type";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Type);
        oprot.WriteFieldEnd();
      }
      if (Message != null && __isset.message) {
        field.Name = "message";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Message);
        oprot.WriteFieldEnd();
      }
      if (ClassName != null && __isset.className) {
        field.Name = "className";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ClassName);
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
    StringBuilder __sb = new StringBuilder("AlluxioTException(");
    bool __first = true;
    if (Type != null && __isset.type) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Type: ");
      __sb.Append(Type);
    }
    if (Message != null && __isset.message) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Message: ");
      __sb.Append(Message);
    }
    if (ClassName != null && __isset.className) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ClassName: ");
      __sb.Append(ClassName);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
