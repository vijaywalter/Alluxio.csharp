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
public partial class SetAttributeTOptions : TBase
{
  private bool _pinned;
  private long _ttl;
  private bool _persisted;
  private string _owner;
  private string _group;
  private short _mode;
  private bool _recursive;

  public bool Pinned
  {
    get
    {
      return _pinned;
    }
    set
    {
      __isset.pinned = true;
      this._pinned = value;
    }
  }

  public long Ttl
  {
    get
    {
      return _ttl;
    }
    set
    {
      __isset.ttl = true;
      this._ttl = value;
    }
  }

  public bool Persisted
  {
    get
    {
      return _persisted;
    }
    set
    {
      __isset.persisted = true;
      this._persisted = value;
    }
  }

  public string Owner
  {
    get
    {
      return _owner;
    }
    set
    {
      __isset.owner = true;
      this._owner = value;
    }
  }

  public string Group
  {
    get
    {
      return _group;
    }
    set
    {
      __isset.@group = true;
      this._group = value;
    }
  }

  public short Mode
  {
    get
    {
      return _mode;
    }
    set
    {
      __isset.mode = true;
      this._mode = value;
    }
  }

  public bool Recursive
  {
    get
    {
      return _recursive;
    }
    set
    {
      __isset.recursive = true;
      this._recursive = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool pinned;
    public bool ttl;
    public bool persisted;
    public bool owner;
    public bool @group;
    public bool mode;
    public bool recursive;
  }

  public SetAttributeTOptions() {
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
            if (field.Type == TType.Bool) {
              Pinned = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              Ttl = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              Persisted = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Owner = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Group = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I16) {
              Mode = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Bool) {
              Recursive = iprot.ReadBool();
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
      TStruct struc = new TStruct("SetAttributeTOptions");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.pinned) {
        field.Name = "pinned";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Pinned);
        oprot.WriteFieldEnd();
      }
      if (__isset.ttl) {
        field.Name = "ttl";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Ttl);
        oprot.WriteFieldEnd();
      }
      if (__isset.persisted) {
        field.Name = "persisted";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Persisted);
        oprot.WriteFieldEnd();
      }
      if (Owner != null && __isset.owner) {
        field.Name = "owner";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Owner);
        oprot.WriteFieldEnd();
      }
      if (Group != null && __isset.@group) {
        field.Name = "group";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Group);
        oprot.WriteFieldEnd();
      }
      if (__isset.mode) {
        field.Name = "mode";
        field.Type = TType.I16;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Mode);
        oprot.WriteFieldEnd();
      }
      if (__isset.recursive) {
        field.Name = "recursive";
        field.Type = TType.Bool;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Recursive);
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
    StringBuilder __sb = new StringBuilder("SetAttributeTOptions(");
    bool __first = true;
    if (__isset.pinned) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Pinned: ");
      __sb.Append(Pinned);
    }
    if (__isset.ttl) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Ttl: ");
      __sb.Append(Ttl);
    }
    if (__isset.persisted) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Persisted: ");
      __sb.Append(Persisted);
    }
    if (Owner != null && __isset.owner) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Owner: ");
      __sb.Append(Owner);
    }
    if (Group != null && __isset.@group) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Group: ");
      __sb.Append(Group);
    }
    if (__isset.mode) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Mode: ");
      __sb.Append(Mode);
    }
    if (__isset.recursive) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Recursive: ");
      __sb.Append(Recursive);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

