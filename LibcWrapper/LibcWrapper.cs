using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LibcWrapper
{
    public partial struct __fsid_t
    {
        [NativeTypeName("int[2]")]
        public ___val_e__FixedBuffer __val;

        [InlineArray(2)]
        public partial struct ___val_e__FixedBuffer
        {
            public int e0;
        }
    }

    public partial struct __sigset_t
    {
        [NativeTypeName("unsigned long[16]")]
        public ___val_e__FixedBuffer __val;

        [InlineArray(16)]
        public partial struct ___val_e__FixedBuffer
        {
            public nuint e0;
        }
    }

    public partial struct timespec
    {
        [NativeTypeName("__time_t")]
        public nint tv_sec;

        [NativeTypeName("__syscall_slong_t")]
        public nint tv_nsec;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct sigval
    {
        [FieldOffset(0)]
        public int sival_int;

        [FieldOffset(0)]
        public void* sival_ptr;
    }

    public partial struct siginfo_t
    {
        public int si_signo;

        public int si_errno;

        public int si_code;

        public int __pad0;

        [NativeTypeName("__AnonymousRecord_siginfo_t_L51_C5")]
        public __sifields_e__Union _sifields;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct __sifields_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int[28]")]
            public __pad_e__FixedBuffer _pad;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L56_C2")]
            public __kill_e__Struct _kill;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L63_C2")]
            public __timer_e__Struct _timer;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L71_C2")]
            public __rt_e__Struct _rt;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L79_C2")]
            public __sigchld_e__Struct _sigchld;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L89_C2")]
            public __sigfault_e__Struct _sigfault;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L108_C2")]
            public __sigpoll_e__Struct _sigpoll;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_siginfo_t_L116_C2")]
            public __sigsys_e__Struct _sigsys;

            public partial struct __kill_e__Struct
            {
                [NativeTypeName("__pid_t")]
                public int si_pid;

                [NativeTypeName("__uid_t")]
                public uint si_uid;
            }

            public partial struct __timer_e__Struct
            {
                public int si_tid;

                public int si_overrun;

                [NativeTypeName("__sigval_t")]
                public sigval si_sigval;
            }

            public partial struct __rt_e__Struct
            {
                [NativeTypeName("__pid_t")]
                public int si_pid;

                [NativeTypeName("__uid_t")]
                public uint si_uid;

                [NativeTypeName("__sigval_t")]
                public sigval si_sigval;
            }

            public partial struct __sigchld_e__Struct
            {
                [NativeTypeName("__pid_t")]
                public int si_pid;

                [NativeTypeName("__uid_t")]
                public uint si_uid;

                public int si_status;

                [NativeTypeName("__clock_t")]
                public nint si_utime;

                [NativeTypeName("__clock_t")]
                public nint si_stime;
            }

            public unsafe partial struct __sigfault_e__Struct
            {
                public void* si_addr;

                public short si_addr_lsb;

                [NativeTypeName("__AnonymousRecord_siginfo_t_L94_C6")]
                public __bounds_e__Union _bounds;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct __bounds_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("__AnonymousRecord_siginfo_t_L97_C3")]
                    public __addr_bnd_e__Struct _addr_bnd;

                    [FieldOffset(0)]
                    [NativeTypeName("__uint32_t")]
                    public uint _pkey;

                    public unsafe partial struct __addr_bnd_e__Struct
                    {
                        public void* _lower;

                        public void* _upper;
                    }
                }
            }

            public partial struct __sigpoll_e__Struct
            {
                [NativeTypeName("long")]
                public nint si_band;

                public int si_fd;
            }

            public unsafe partial struct __sigsys_e__Struct
            {
                public void* _call_addr;

                public int _syscall;

                [NativeTypeName("unsigned int")]
                public uint _arch;
            }

            [InlineArray(28)]
            public partial struct __pad_e__FixedBuffer
            {
                public int e0;
            }
        }
    }

    public partial struct sigevent
    {
        [NativeTypeName("__sigval_t")]
        public sigval sigev_value;

        public int sigev_signo;

        public int sigev_notify;

        [NativeTypeName("__AnonymousRecord_sigevent_t_L28_C5")]
        public __sigev_un_e__Union _sigev_un;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct __sigev_un_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int[12]")]
            public __pad_e__FixedBuffer _pad;

            [FieldOffset(0)]
            [NativeTypeName("__pid_t")]
            public int _tid;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_sigevent_t_L36_C2")]
            public __sigev_thread_e__Struct _sigev_thread;

            public unsafe partial struct __sigev_thread_e__Struct
            {
                [NativeTypeName("void (*)(__sigval_t)")]
                public delegate* unmanaged[Cdecl]<sigval, void> _function;

                public pthread_attr_t* _attribute;
            }

            [InlineArray(12)]
            public partial struct __pad_e__FixedBuffer
            {
                public int e0;
            }
        }
    }

    public unsafe partial struct sigaction
    {
        [NativeTypeName("__AnonymousRecord_sigaction_L31_C5")]
        public ___sigaction_handler_e__Union __sigaction_handler;

        public __sigset_t sa_mask;

        public int sa_flags;

        [NativeTypeName("void (*)()")]
        public delegate* unmanaged[Cdecl]<void> sa_restorer;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct ___sigaction_handler_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__sighandler_t")]
            public delegate* unmanaged[Cdecl]<int, void> sa_handler;

            [FieldOffset(0)]
            [NativeTypeName("void (*)(int, siginfo_t *, void *)")]
            public delegate* unmanaged[Cdecl]<int, siginfo_t*, void*, void> sa_sigaction;
        }
    }

    public partial struct _fpx_sw_bytes
    {
        [NativeTypeName("__uint32_t")]
        public uint magic1;

        [NativeTypeName("__uint32_t")]
        public uint extended_size;

        [NativeTypeName("__uint64_t")]
        public ulong xstate_bv;

        [NativeTypeName("__uint32_t")]
        public uint xstate_size;

        [NativeTypeName("__uint32_t[7]")]
        public ___glibc_reserved1_e__FixedBuffer __glibc_reserved1;

        [InlineArray(7)]
        public partial struct ___glibc_reserved1_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct _fpreg
    {
        [NativeTypeName("unsigned short[4]")]
        public _significand_e__FixedBuffer significand;

        [NativeTypeName("unsigned short")]
        public ushort exponent;

        [InlineArray(4)]
        public partial struct _significand_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct _fpxreg
    {
        [NativeTypeName("unsigned short[4]")]
        public _significand_e__FixedBuffer significand;

        [NativeTypeName("unsigned short")]
        public ushort exponent;

        [NativeTypeName("unsigned short[3]")]
        public ___glibc_reserved1_e__FixedBuffer __glibc_reserved1;

        [InlineArray(4)]
        public partial struct _significand_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct ___glibc_reserved1_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct _xmmreg
    {
        [NativeTypeName("__uint32_t[4]")]
        public _element_e__FixedBuffer element;

        [InlineArray(4)]
        public partial struct _element_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct _fpstate
    {
        [NativeTypeName("__uint16_t")]
        public ushort cwd;

        [NativeTypeName("__uint16_t")]
        public ushort swd;

        [NativeTypeName("__uint16_t")]
        public ushort ftw;

        [NativeTypeName("__uint16_t")]
        public ushort fop;

        [NativeTypeName("__uint64_t")]
        public ulong rip;

        [NativeTypeName("__uint64_t")]
        public ulong rdp;

        [NativeTypeName("__uint32_t")]
        public uint mxcsr;

        [NativeTypeName("__uint32_t")]
        public uint mxcr_mask;

        [NativeTypeName("struct _fpxreg[8]")]
        public __st_e__FixedBuffer _st;

        [NativeTypeName("struct _xmmreg[16]")]
        public __xmm_e__FixedBuffer _xmm;

        [NativeTypeName("__uint32_t[24]")]
        public ___glibc_reserved1_e__FixedBuffer __glibc_reserved1;

        [InlineArray(8)]
        public partial struct __st_e__FixedBuffer
        {
            public _fpxreg e0;
        }

        [InlineArray(16)]
        public partial struct __xmm_e__FixedBuffer
        {
            public _xmmreg e0;
        }

        [InlineArray(24)]
        public partial struct ___glibc_reserved1_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public unsafe partial struct sigcontext
    {
        [NativeTypeName("__uint64_t")]
        public ulong r8;

        [NativeTypeName("__uint64_t")]
        public ulong r9;

        [NativeTypeName("__uint64_t")]
        public ulong r10;

        [NativeTypeName("__uint64_t")]
        public ulong r11;

        [NativeTypeName("__uint64_t")]
        public ulong r12;

        [NativeTypeName("__uint64_t")]
        public ulong r13;

        [NativeTypeName("__uint64_t")]
        public ulong r14;

        [NativeTypeName("__uint64_t")]
        public ulong r15;

        [NativeTypeName("__uint64_t")]
        public ulong rdi;

        [NativeTypeName("__uint64_t")]
        public ulong rsi;

        [NativeTypeName("__uint64_t")]
        public ulong rbp;

        [NativeTypeName("__uint64_t")]
        public ulong rbx;

        [NativeTypeName("__uint64_t")]
        public ulong rdx;

        [NativeTypeName("__uint64_t")]
        public ulong rax;

        [NativeTypeName("__uint64_t")]
        public ulong rcx;

        [NativeTypeName("__uint64_t")]
        public ulong rsp;

        [NativeTypeName("__uint64_t")]
        public ulong rip;

        [NativeTypeName("__uint64_t")]
        public ulong eflags;

        [NativeTypeName("unsigned short")]
        public ushort cs;

        [NativeTypeName("unsigned short")]
        public ushort gs;

        [NativeTypeName("unsigned short")]
        public ushort fs;

        [NativeTypeName("unsigned short")]
        public ushort __pad0;

        [NativeTypeName("__uint64_t")]
        public ulong err;

        [NativeTypeName("__uint64_t")]
        public ulong trapno;

        [NativeTypeName("__uint64_t")]
        public ulong oldmask;

        [NativeTypeName("__uint64_t")]
        public ulong cr2;

        [NativeTypeName("__AnonymousRecord_sigcontext_L167_C17")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("__uint64_t[8]")]
        public ___reserved1_e__FixedBuffer __reserved1;

        [UnscopedRef]
        public ref _fpstate* fpstate
        {
            get
            {
                return ref Anonymous.fpstate;
            }
        }

        [UnscopedRef]
        public ref ulong __fpstate_word
        {
            get
            {
                return ref Anonymous.__fpstate_word;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct _fpstate *")]
            public _fpstate* fpstate;

            [FieldOffset(0)]
            [NativeTypeName("__uint64_t")]
            public ulong __fpstate_word;
        }

        [InlineArray(8)]
        public partial struct ___reserved1_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _xsave_hdr
    {
        [NativeTypeName("__uint64_t")]
        public ulong xstate_bv;

        [NativeTypeName("__uint64_t[2]")]
        public ___glibc_reserved1_e__FixedBuffer __glibc_reserved1;

        [NativeTypeName("__uint64_t[5]")]
        public ___glibc_reserved2_e__FixedBuffer __glibc_reserved2;

        [InlineArray(2)]
        public partial struct ___glibc_reserved1_e__FixedBuffer
        {
            public ulong e0;
        }

        [InlineArray(5)]
        public partial struct ___glibc_reserved2_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _ymmh_state
    {
        [NativeTypeName("__uint32_t[64]")]
        public _ymmh_space_e__FixedBuffer ymmh_space;

        [InlineArray(64)]
        public partial struct _ymmh_space_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct _xstate
    {
        [NativeTypeName("struct _fpstate")]
        public _fpstate fpstate;

        [NativeTypeName("struct _xsave_hdr")]
        public _xsave_hdr xstate_hdr;

        [NativeTypeName("struct _ymmh_state")]
        public _ymmh_state ymmh;
    }

    public unsafe partial struct stack_t
    {
        public void* ss_sp;

        public int ss_flags;

        [NativeTypeName("size_t")]
        public nuint ss_size;
    }

    public partial struct _libc_fpxreg
    {
        [NativeTypeName("unsigned short[4]")]
        public _significand_e__FixedBuffer significand;

        [NativeTypeName("unsigned short")]
        public ushort exponent;

        [NativeTypeName("unsigned short[3]")]
        public ___glibc_reserved1_e__FixedBuffer __glibc_reserved1;

        [InlineArray(4)]
        public partial struct _significand_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct ___glibc_reserved1_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct _libc_xmmreg
    {
        [NativeTypeName("__uint32_t[4]")]
        public _element_e__FixedBuffer element;

        [InlineArray(4)]
        public partial struct _element_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct _libc_fpstate
    {
        [NativeTypeName("__uint16_t")]
        public ushort cwd;

        [NativeTypeName("__uint16_t")]
        public ushort swd;

        [NativeTypeName("__uint16_t")]
        public ushort ftw;

        [NativeTypeName("__uint16_t")]
        public ushort fop;

        [NativeTypeName("__uint64_t")]
        public ulong rip;

        [NativeTypeName("__uint64_t")]
        public ulong rdp;

        [NativeTypeName("__uint32_t")]
        public uint mxcsr;

        [NativeTypeName("__uint32_t")]
        public uint mxcr_mask;

        [NativeTypeName("struct _libc_fpxreg[8]")]
        public __st_e__FixedBuffer _st;

        [NativeTypeName("struct _libc_xmmreg[16]")]
        public __xmm_e__FixedBuffer _xmm;

        [NativeTypeName("__uint32_t[24]")]
        public ___glibc_reserved1_e__FixedBuffer __glibc_reserved1;

        [InlineArray(8)]
        public partial struct __st_e__FixedBuffer
        {
            public _libc_fpxreg e0;
        }

        [InlineArray(16)]
        public partial struct __xmm_e__FixedBuffer
        {
            public _libc_xmmreg e0;
        }

        [InlineArray(24)]
        public partial struct ___glibc_reserved1_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public unsafe partial struct mcontext_t
    {
        [NativeTypeName("gregset_t")]
        public _gregs_e__FixedBuffer gregs;

        [NativeTypeName("fpregset_t")]
        public _libc_fpstate* fpregs;

        [NativeTypeName("unsigned long long[8]")]
        public ___reserved1_e__FixedBuffer __reserved1;

        [InlineArray(23)]
        public partial struct _gregs_e__FixedBuffer
        {
            public long e0;
        }

        [InlineArray(8)]
        public partial struct ___reserved1_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public unsafe partial struct ucontext_t
    {
        [NativeTypeName("unsigned long")]
        public nuint uc_flags;

        [NativeTypeName("struct ucontext_t *")]
        public ucontext_t* uc_link;

        public stack_t uc_stack;

        public mcontext_t uc_mcontext;

        [NativeTypeName("sigset_t")]
        public __sigset_t uc_sigmask;

        [NativeTypeName("struct _libc_fpstate")]
        public _libc_fpstate __fpregs_mem;

        [NativeTypeName("unsigned long long[4]")]
        public ___ssp_e__FixedBuffer __ssp;

        [InlineArray(4)]
        public partial struct ___ssp_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct __atomic_wide_counter
    {
        [FieldOffset(0)]
        [NativeTypeName("unsigned long long")]
        public ulong __value64;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_atomic_wide_counter_L28_C3")]
        public ___value32_e__Struct __value32;

        public partial struct ___value32_e__Struct
        {
            [NativeTypeName("unsigned int")]
            public uint __low;

            [NativeTypeName("unsigned int")]
            public uint __high;
        }
    }

    public unsafe partial struct __pthread_internal_list
    {
        [NativeTypeName("struct __pthread_internal_list *")]
        public __pthread_internal_list* __prev;

        [NativeTypeName("struct __pthread_internal_list *")]
        public __pthread_internal_list* __next;
    }

    public unsafe partial struct __pthread_internal_slist
    {
        [NativeTypeName("struct __pthread_internal_slist *")]
        public __pthread_internal_slist* __next;
    }

    public partial struct __pthread_mutex_s
    {
        public int __lock;

        [NativeTypeName("unsigned int")]
        public uint __count;

        public int __owner;

        [NativeTypeName("unsigned int")]
        public uint __nusers;

        public int __kind;

        public short __spins;

        public short __elision;

        [NativeTypeName("__pthread_list_t")]
        public __pthread_internal_list __list;
    }

    public partial struct __pthread_rwlock_arch_t
    {
        [NativeTypeName("unsigned int")]
        public uint __readers;

        [NativeTypeName("unsigned int")]
        public uint __writers;

        [NativeTypeName("unsigned int")]
        public uint __wrphase_futex;

        [NativeTypeName("unsigned int")]
        public uint __writers_futex;

        [NativeTypeName("unsigned int")]
        public uint __pad3;

        [NativeTypeName("unsigned int")]
        public uint __pad4;

        public int __cur_writer;

        public int __shared;

        [NativeTypeName("signed char")]
        public sbyte __rwelision;

        [NativeTypeName("unsigned char[7]")]
        public ___pad1_e__FixedBuffer __pad1;

        [NativeTypeName("unsigned long")]
        public nuint __pad2;

        [NativeTypeName("unsigned int")]
        public uint __flags;

        [InlineArray(7)]
        public partial struct ___pad1_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct __pthread_cond_s
    {
        public __atomic_wide_counter __wseq;

        public __atomic_wide_counter __g1_start;

        [NativeTypeName("unsigned int[2]")]
        public ___g_refs_e__FixedBuffer __g_refs;

        [NativeTypeName("unsigned int[2]")]
        public ___g_size_e__FixedBuffer __g_size;

        [NativeTypeName("unsigned int")]
        public uint __g1_orig_size;

        [NativeTypeName("unsigned int")]
        public uint __wrefs;

        [NativeTypeName("unsigned int[2]")]
        public ___g_signals_e__FixedBuffer __g_signals;

        [InlineArray(2)]
        public partial struct ___g_refs_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(2)]
        public partial struct ___g_size_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(2)]
        public partial struct ___g_signals_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct __once_flag
    {
        public int __data;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_mutexattr_t
    {
        [FieldOffset(0)]
        [NativeTypeName("char[4]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        public int __align;

        [InlineArray(4)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_condattr_t
    {
        [FieldOffset(0)]
        [NativeTypeName("char[4]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        public int __align;

        [InlineArray(4)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_attr_t
    {
        [FieldOffset(0)]
        [NativeTypeName("char[56]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        [NativeTypeName("long")]
        public nint __align;

        [InlineArray(56)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_mutex_t
    {
        [FieldOffset(0)]
        [NativeTypeName("struct __pthread_mutex_s")]
        public __pthread_mutex_s __data;

        [FieldOffset(0)]
        [NativeTypeName("char[40]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        [NativeTypeName("long")]
        public nint __align;

        [InlineArray(40)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_cond_t
    {
        [FieldOffset(0)]
        [NativeTypeName("struct __pthread_cond_s")]
        public __pthread_cond_s __data;

        [FieldOffset(0)]
        [NativeTypeName("char[48]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        [NativeTypeName("long long")]
        public long __align;

        [InlineArray(48)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_rwlock_t
    {
        [FieldOffset(0)]
        [NativeTypeName("struct __pthread_rwlock_arch_t")]
        public __pthread_rwlock_arch_t __data;

        [FieldOffset(0)]
        [NativeTypeName("char[56]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        [NativeTypeName("long")]
        public nint __align;

        [InlineArray(56)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_rwlockattr_t
    {
        [FieldOffset(0)]
        [NativeTypeName("char[8]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        [NativeTypeName("long")]
        public nint __align;

        [InlineArray(8)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_barrier_t
    {
        [FieldOffset(0)]
        [NativeTypeName("char[32]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        [NativeTypeName("long")]
        public nint __align;

        [InlineArray(32)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct pthread_barrierattr_t
    {
        [FieldOffset(0)]
        [NativeTypeName("char[4]")]
        public ___size_e__FixedBuffer __size;

        [FieldOffset(0)]
        public int __align;

        [InlineArray(4)]
        public partial struct ___size_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [NativeTypeName("unsigned int")]
    public enum idtype_t : uint
    {
        P_ALL,
        P_PID,
        P_PGID,
        P_PIDFD,
    }

    public partial struct rusage
    {
    }

    public partial struct flock
    {
        public short l_type;

        public short l_whence;

        [NativeTypeName("__off_t")]
        public nint l_start;

        [NativeTypeName("__off_t")]
        public nint l_len;

        [NativeTypeName("__pid_t")]
        public int l_pid;
    }

    public partial struct flock64
    {
        public short l_type;

        public short l_whence;

        [NativeTypeName("__off64_t")]
        public nint l_start;

        [NativeTypeName("__off64_t")]
        public nint l_len;

        [NativeTypeName("__pid_t")]
        public int l_pid;
    }

    public unsafe partial struct iovec
    {
        public void* iov_base;

        [NativeTypeName("size_t")]
        public nuint iov_len;
    }

    [NativeTypeName("unsigned int")]
    public enum __pid_type : uint
    {
        F_OWNER_TID = 0,
        F_OWNER_PID,
        F_OWNER_PGRP,
        F_OWNER_GID = F_OWNER_PGRP,
    }

    public partial struct f_owner_ex
    {
        [NativeTypeName("enum __pid_type")]
        public __pid_type type;

        [NativeTypeName("__pid_t")]
        public int pid;
    }

    public partial struct file_handle
    {
        [NativeTypeName("unsigned int")]
        public uint handle_bytes;

        public int handle_type;

        [NativeTypeName("unsigned char[0]")]
        public _f_handle_e__FixedBuffer f_handle;

        public partial struct _f_handle_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct stat
    {
        [NativeTypeName("__dev_t")]
        public nuint st_dev;

        [NativeTypeName("__ino_t")]
        public nuint st_ino;

        [NativeTypeName("__nlink_t")]
        public nuint st_nlink;

        [NativeTypeName("__mode_t")]
        public uint st_mode;

        [NativeTypeName("__uid_t")]
        public uint st_uid;

        [NativeTypeName("__gid_t")]
        public uint st_gid;

        public int __pad0;

        [NativeTypeName("__dev_t")]
        public nuint st_rdev;

        [NativeTypeName("__off_t")]
        public nint st_size;

        [NativeTypeName("__blksize_t")]
        public nint st_blksize;

        [NativeTypeName("__blkcnt_t")]
        public nint st_blocks;

        [NativeTypeName("struct timespec")]
        public timespec st_atim;

        [NativeTypeName("struct timespec")]
        public timespec st_mtim;

        [NativeTypeName("struct timespec")]
        public timespec st_ctim;

        [NativeTypeName("__syscall_slong_t[3]")]
        public ___glibc_reserved_e__FixedBuffer __glibc_reserved;

        [InlineArray(3)]
        public partial struct ___glibc_reserved_e__FixedBuffer
        {
            public nint e0;
        }
    }

    public partial struct stat64
    {
        [NativeTypeName("__dev_t")]
        public nuint st_dev;

        [NativeTypeName("__ino64_t")]
        public nuint st_ino;

        [NativeTypeName("__nlink_t")]
        public nuint st_nlink;

        [NativeTypeName("__mode_t")]
        public uint st_mode;

        [NativeTypeName("__uid_t")]
        public uint st_uid;

        [NativeTypeName("__gid_t")]
        public uint st_gid;

        public int __pad0;

        [NativeTypeName("__dev_t")]
        public nuint st_rdev;

        [NativeTypeName("__off_t")]
        public nint st_size;

        [NativeTypeName("__blksize_t")]
        public nint st_blksize;

        [NativeTypeName("__blkcnt64_t")]
        public nint st_blocks;

        [NativeTypeName("struct timespec")]
        public timespec st_atim;

        [NativeTypeName("struct timespec")]
        public timespec st_mtim;

        [NativeTypeName("struct timespec")]
        public timespec st_ctim;

        [NativeTypeName("__syscall_slong_t[3]")]
        public ___glibc_reserved_e__FixedBuffer __glibc_reserved;

        [InlineArray(3)]
        public partial struct ___glibc_reserved_e__FixedBuffer
        {
            public nint e0;
        }
    }

    public partial struct sched_param
    {
        public int sched_priority;
    }

    public partial struct cpu_set_t
    {
        [NativeTypeName("__cpu_mask[16]")]
        public ___bits_e__FixedBuffer __bits;

        [InlineArray(16)]
        public partial struct ___bits_e__FixedBuffer
        {
            public nuint e0;
        }
    }

    public partial struct timeval
    {
        [NativeTypeName("__time_t")]
        public nint tv_sec;

        [NativeTypeName("__suseconds_t")]
        public nint tv_usec;
    }

    public partial struct fd_set
    {
        [NativeTypeName("__fd_mask[16]")]
        public _fds_bits_e__FixedBuffer fds_bits;

        [InlineArray(16)]
        public partial struct _fds_bits_e__FixedBuffer
        {
            public nint e0;
        }
    }

    public partial struct posix_spawnattr_t
    {
        public short __flags;

        [NativeTypeName("pid_t")]
        public int __pgrp;

        [NativeTypeName("sigset_t")]
        public __sigset_t __sd;

        [NativeTypeName("sigset_t")]
        public __sigset_t __ss;

        [NativeTypeName("struct sched_param")]
        public sched_param __sp;

        public int __policy;

        public int __cgroup;

        [NativeTypeName("int[15]")]
        public ___pad_e__FixedBuffer __pad;

        [InlineArray(15)]
        public partial struct ___pad_e__FixedBuffer
        {
            public int e0;
        }
    }

    public unsafe partial struct posix_spawn_file_actions_t
    {
        public int __allocated;

        public int __used;

        [NativeTypeName("struct __spawn_action *")]
        public __spawn_action* __actions;

        [NativeTypeName("int[16]")]
        public ___pad_e__FixedBuffer __pad;

        public partial struct __spawn_action
        {
        }

        [InlineArray(16)]
        public partial struct ___pad_e__FixedBuffer
        {
            public int e0;
        }
    }

    public static unsafe partial class Methods
    {
        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int access([NativeTypeName("const char *")] sbyte* __name, int __type);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int euidaccess([NativeTypeName("const char *")] sbyte* __name, int __type);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int eaccess([NativeTypeName("const char *")] sbyte* __name, int __type);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execveat(int __fd, [NativeTypeName("const char *")] sbyte* __path, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int faccessat(int __fd, [NativeTypeName("const char *")] sbyte* __file, int __type, int __flag);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__off_t")]
        public static extern nint lseek(int __fd, [NativeTypeName("__off_t")] nint __offset, int __whence);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__off64_t")]
        public static extern nint lseek64(int __fd, [NativeTypeName("__off64_t")] nint __offset, int __whence);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int close(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void closefrom(int __lowfd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint read(int __fd, void* __buf, [NativeTypeName("size_t")] nuint __nbytes);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint write(int __fd, [NativeTypeName("const void *")] void* __buf, [NativeTypeName("size_t")] nuint __n);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint pread(int __fd, void* __buf, [NativeTypeName("size_t")] nuint __nbytes, [NativeTypeName("__off_t")] nint __offset);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint pwrite(int __fd, [NativeTypeName("const void *")] void* __buf, [NativeTypeName("size_t")] nuint __n, [NativeTypeName("__off_t")] nint __offset);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint pread64(int __fd, void* __buf, [NativeTypeName("size_t")] nuint __nbytes, [NativeTypeName("__off64_t")] nint __offset);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint pwrite64(int __fd, [NativeTypeName("const void *")] void* __buf, [NativeTypeName("size_t")] nuint __n, [NativeTypeName("__off64_t")] nint __offset);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pipe([NativeTypeName("int[2]")] int* __pipedes);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pipe2([NativeTypeName("int[2]")] int* __pipedes, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint alarm([NativeTypeName("unsigned int")] uint __seconds);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint sleep([NativeTypeName("unsigned int")] uint __seconds);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__useconds_t")]
        public static extern uint ualarm([NativeTypeName("__useconds_t")] uint __value, [NativeTypeName("__useconds_t")] uint __interval);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int usleep([NativeTypeName("__useconds_t")] uint __useconds);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pause();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chown([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("__uid_t")] uint __owner, [NativeTypeName("__gid_t")] uint __group);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fchown(int __fd, [NativeTypeName("__uid_t")] uint __owner, [NativeTypeName("__gid_t")] uint __group);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lchown([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("__uid_t")] uint __owner, [NativeTypeName("__gid_t")] uint __group);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fchownat(int __fd, [NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("__uid_t")] uint __owner, [NativeTypeName("__gid_t")] uint __group, int __flag);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chdir([NativeTypeName("const char *")] sbyte* __path);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fchdir(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* getcwd([NativeTypeName("char *")] sbyte* __buf, [NativeTypeName("size_t")] nuint __size);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* get_current_dir_name();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        [Obsolete]
        public static extern sbyte* getwd([NativeTypeName("char *")] sbyte* __buf);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dup(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dup2(int __fd, int __fd2);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dup3(int __fd, int __fd2, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execve([NativeTypeName("const char *")] sbyte* __path, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fexecve(int __fd, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execv([NativeTypeName("const char *")] sbyte* __path, [NativeTypeName("char *const[]")] sbyte** __argv);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execle([NativeTypeName("const char *")] sbyte* __path, [NativeTypeName("const char *")] sbyte* __arg, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execl([NativeTypeName("const char *")] sbyte* __path, [NativeTypeName("const char *")] sbyte* __arg, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execvp([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("char *const[]")] sbyte** __argv);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execlp([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("const char *")] sbyte* __arg, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int execvpe([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int nice(int __inc);

        public const uint _PC_LINK_MAX = 0;
        public const uint _PC_MAX_CANON = 1;
        public const uint _PC_MAX_INPUT = 2;
        public const uint _PC_NAME_MAX = 3;
        public const uint _PC_PATH_MAX = 4;
        public const uint _PC_PIPE_BUF = 5;
        public const uint _PC_CHOWN_RESTRICTED = 6;
        public const uint _PC_NO_TRUNC = 7;
        public const uint _PC_VDISABLE = 8;
        public const uint _PC_SYNC_IO = 9;
        public const uint _PC_ASYNC_IO = 10;
        public const uint _PC_PRIO_IO = 11;
        public const uint _PC_SOCK_MAXBUF = 12;
        public const uint _PC_FILESIZEBITS = 13;
        public const uint _PC_REC_INCR_XFER_SIZE = 14;
        public const uint _PC_REC_MAX_XFER_SIZE = 15;
        public const uint _PC_REC_MIN_XFER_SIZE = 16;
        public const uint _PC_REC_XFER_ALIGN = 17;
        public const uint _PC_ALLOC_SIZE_MIN = 18;
        public const uint _PC_SYMLINK_MAX = 19;
        public const uint _PC_2_SYMLINKS = 20;

        public const uint _SC_ARG_MAX = 0;
        public const uint _SC_CHILD_MAX = 1;
        public const uint _SC_CLK_TCK = 2;
        public const uint _SC_NGROUPS_MAX = 3;
        public const uint _SC_OPEN_MAX = 4;
        public const uint _SC_STREAM_MAX = 5;
        public const uint _SC_TZNAME_MAX = 6;
        public const uint _SC_JOB_CONTROL = 7;
        public const uint _SC_SAVED_IDS = 8;
        public const uint _SC_REALTIME_SIGNALS = 9;
        public const uint _SC_PRIORITY_SCHEDULING = 10;
        public const uint _SC_TIMERS = 11;
        public const uint _SC_ASYNCHRONOUS_IO = 12;
        public const uint _SC_PRIORITIZED_IO = 13;
        public const uint _SC_SYNCHRONIZED_IO = 14;
        public const uint _SC_FSYNC = 15;
        public const uint _SC_MAPPED_FILES = 16;
        public const uint _SC_MEMLOCK = 17;
        public const uint _SC_MEMLOCK_RANGE = 18;
        public const uint _SC_MEMORY_PROTECTION = 19;
        public const uint _SC_MESSAGE_PASSING = 20;
        public const uint _SC_SEMAPHORES = 21;
        public const uint _SC_SHARED_MEMORY_OBJECTS = 22;
        public const uint _SC_AIO_LISTIO_MAX = 23;
        public const uint _SC_AIO_MAX = 24;
        public const uint _SC_AIO_PRIO_DELTA_MAX = 25;
        public const uint _SC_DELAYTIMER_MAX = 26;
        public const uint _SC_MQ_OPEN_MAX = 27;
        public const uint _SC_MQ_PRIO_MAX = 28;
        public const uint _SC_VERSION = 29;
        public const uint _SC_PAGESIZE = 30;
        public const uint _SC_RTSIG_MAX = 31;
        public const uint _SC_SEM_NSEMS_MAX = 32;
        public const uint _SC_SEM_VALUE_MAX = 33;
        public const uint _SC_SIGQUEUE_MAX = 34;
        public const uint _SC_TIMER_MAX = 35;
        public const uint _SC_BC_BASE_MAX = 36;
        public const uint _SC_BC_DIM_MAX = 37;
        public const uint _SC_BC_SCALE_MAX = 38;
        public const uint _SC_BC_STRING_MAX = 39;
        public const uint _SC_COLL_WEIGHTS_MAX = 40;
        public const uint _SC_EQUIV_CLASS_MAX = 41;
        public const uint _SC_EXPR_NEST_MAX = 42;
        public const uint _SC_LINE_MAX = 43;
        public const uint _SC_RE_DUP_MAX = 44;
        public const uint _SC_CHARCLASS_NAME_MAX = 45;
        public const uint _SC_2_VERSION = 46;
        public const uint _SC_2_C_BIND = 47;
        public const uint _SC_2_C_DEV = 48;
        public const uint _SC_2_FORT_DEV = 49;
        public const uint _SC_2_FORT_RUN = 50;
        public const uint _SC_2_SW_DEV = 51;
        public const uint _SC_2_LOCALEDEF = 52;
        public const uint _SC_PII = 53;
        public const uint _SC_PII_XTI = 54;
        public const uint _SC_PII_SOCKET = 55;
        public const uint _SC_PII_INTERNET = 56;
        public const uint _SC_PII_OSI = 57;
        public const uint _SC_POLL = 58;
        public const uint _SC_SELECT = 59;
        public const uint _SC_UIO_MAXIOV = 60;
        public const uint _SC_IOV_MAX = _SC_UIO_MAXIOV;
        public const uint _SC_PII_INTERNET_STREAM = 61;
        public const uint _SC_PII_INTERNET_DGRAM = 62;
        public const uint _SC_PII_OSI_COTS = 63;
        public const uint _SC_PII_OSI_CLTS = 64;
        public const uint _SC_PII_OSI_M = 65;
        public const uint _SC_T_IOV_MAX = 66;
        public const uint _SC_THREADS = 67;
        public const uint _SC_THREAD_SAFE_FUNCTIONS = 68;
        public const uint _SC_GETGR_R_SIZE_MAX = 69;
        public const uint _SC_GETPW_R_SIZE_MAX = 70;
        public const uint _SC_LOGIN_NAME_MAX = 71;
        public const uint _SC_TTY_NAME_MAX = 72;
        public const uint _SC_THREAD_DESTRUCTOR_ITERATIONS = 73;
        public const uint _SC_THREAD_KEYS_MAX = 74;
        public const uint _SC_THREAD_STACK_MIN = 75;
        public const uint _SC_THREAD_THREADS_MAX = 76;
        public const uint _SC_THREAD_ATTR_STACKADDR = 77;
        public const uint _SC_THREAD_ATTR_STACKSIZE = 78;
        public const uint _SC_THREAD_PRIORITY_SCHEDULING = 79;
        public const uint _SC_THREAD_PRIO_INHERIT = 80;
        public const uint _SC_THREAD_PRIO_PROTECT = 81;
        public const uint _SC_THREAD_PROCESS_SHARED = 82;
        public const uint _SC_NPROCESSORS_CONF = 83;
        public const uint _SC_NPROCESSORS_ONLN = 84;
        public const uint _SC_PHYS_PAGES = 85;
        public const uint _SC_AVPHYS_PAGES = 86;
        public const uint _SC_ATEXIT_MAX = 87;
        public const uint _SC_PASS_MAX = 88;
        public const uint _SC_XOPEN_VERSION = 89;
        public const uint _SC_XOPEN_XCU_VERSION = 90;
        public const uint _SC_XOPEN_UNIX = 91;
        public const uint _SC_XOPEN_CRYPT = 92;
        public const uint _SC_XOPEN_ENH_I18N = 93;
        public const uint _SC_XOPEN_SHM = 94;
        public const uint _SC_2_CHAR_TERM = 95;
        public const uint _SC_2_C_VERSION = 96;
        public const uint _SC_2_UPE = 97;
        public const uint _SC_XOPEN_XPG2 = 98;
        public const uint _SC_XOPEN_XPG3 = 99;
        public const uint _SC_XOPEN_XPG4 = 100;
        public const uint _SC_CHAR_BIT = 101;
        public const uint _SC_CHAR_MAX = 102;
        public const uint _SC_CHAR_MIN = 103;
        public const uint _SC_INT_MAX = 104;
        public const uint _SC_INT_MIN = 105;
        public const uint _SC_LONG_BIT = 106;
        public const uint _SC_WORD_BIT = 107;
        public const uint _SC_MB_LEN_MAX = 108;
        public const uint _SC_NZERO = 109;
        public const uint _SC_SSIZE_MAX = 110;
        public const uint _SC_SCHAR_MAX = 111;
        public const uint _SC_SCHAR_MIN = 112;
        public const uint _SC_SHRT_MAX = 113;
        public const uint _SC_SHRT_MIN = 114;
        public const uint _SC_UCHAR_MAX = 115;
        public const uint _SC_UINT_MAX = 116;
        public const uint _SC_ULONG_MAX = 117;
        public const uint _SC_USHRT_MAX = 118;
        public const uint _SC_NL_ARGMAX = 119;
        public const uint _SC_NL_LANGMAX = 120;
        public const uint _SC_NL_MSGMAX = 121;
        public const uint _SC_NL_NMAX = 122;
        public const uint _SC_NL_SETMAX = 123;
        public const uint _SC_NL_TEXTMAX = 124;
        public const uint _SC_XBS5_ILP32_OFF32 = 125;
        public const uint _SC_XBS5_ILP32_OFFBIG = 126;
        public const uint _SC_XBS5_LP64_OFF64 = 127;
        public const uint _SC_XBS5_LPBIG_OFFBIG = 128;
        public const uint _SC_XOPEN_LEGACY = 129;
        public const uint _SC_XOPEN_REALTIME = 130;
        public const uint _SC_XOPEN_REALTIME_THREADS = 131;
        public const uint _SC_ADVISORY_INFO = 132;
        public const uint _SC_BARRIERS = 133;
        public const uint _SC_BASE = 134;
        public const uint _SC_C_LANG_SUPPORT = 135;
        public const uint _SC_C_LANG_SUPPORT_R = 136;
        public const uint _SC_CLOCK_SELECTION = 137;
        public const uint _SC_CPUTIME = 138;
        public const uint _SC_THREAD_CPUTIME = 139;
        public const uint _SC_DEVICE_IO = 140;
        public const uint _SC_DEVICE_SPECIFIC = 141;
        public const uint _SC_DEVICE_SPECIFIC_R = 142;
        public const uint _SC_FD_MGMT = 143;
        public const uint _SC_FIFO = 144;
        public const uint _SC_PIPE = 145;
        public const uint _SC_FILE_ATTRIBUTES = 146;
        public const uint _SC_FILE_LOCKING = 147;
        public const uint _SC_FILE_SYSTEM = 148;
        public const uint _SC_MONOTONIC_CLOCK = 149;
        public const uint _SC_MULTI_PROCESS = 150;
        public const uint _SC_SINGLE_PROCESS = 151;
        public const uint _SC_NETWORKING = 152;
        public const uint _SC_READER_WRITER_LOCKS = 153;
        public const uint _SC_SPIN_LOCKS = 154;
        public const uint _SC_REGEXP = 155;
        public const uint _SC_REGEX_VERSION = 156;
        public const uint _SC_SHELL = 157;
        public const uint _SC_SIGNALS = 158;
        public const uint _SC_SPAWN = 159;
        public const uint _SC_SPORADIC_SERVER = 160;
        public const uint _SC_THREAD_SPORADIC_SERVER = 161;
        public const uint _SC_SYSTEM_DATABASE = 162;
        public const uint _SC_SYSTEM_DATABASE_R = 163;
        public const uint _SC_TIMEOUTS = 164;
        public const uint _SC_TYPED_MEMORY_OBJECTS = 165;
        public const uint _SC_USER_GROUPS = 166;
        public const uint _SC_USER_GROUPS_R = 167;
        public const uint _SC_2_PBS = 168;
        public const uint _SC_2_PBS_ACCOUNTING = 169;
        public const uint _SC_2_PBS_LOCATE = 170;
        public const uint _SC_2_PBS_MESSAGE = 171;
        public const uint _SC_2_PBS_TRACK = 172;
        public const uint _SC_SYMLOOP_MAX = 173;
        public const uint _SC_STREAMS = 174;
        public const uint _SC_2_PBS_CHECKPOINT = 175;
        public const uint _SC_V6_ILP32_OFF32 = 176;
        public const uint _SC_V6_ILP32_OFFBIG = 177;
        public const uint _SC_V6_LP64_OFF64 = 178;
        public const uint _SC_V6_LPBIG_OFFBIG = 179;
        public const uint _SC_HOST_NAME_MAX = 180;
        public const uint _SC_TRACE = 181;
        public const uint _SC_TRACE_EVENT_FILTER = 182;
        public const uint _SC_TRACE_INHERIT = 183;
        public const uint _SC_TRACE_LOG = 184;
        public const uint _SC_LEVEL1_ICACHE_SIZE = 185;
        public const uint _SC_LEVEL1_ICACHE_ASSOC = 186;
        public const uint _SC_LEVEL1_ICACHE_LINESIZE = 187;
        public const uint _SC_LEVEL1_DCACHE_SIZE = 188;
        public const uint _SC_LEVEL1_DCACHE_ASSOC = 189;
        public const uint _SC_LEVEL1_DCACHE_LINESIZE = 190;
        public const uint _SC_LEVEL2_CACHE_SIZE = 191;
        public const uint _SC_LEVEL2_CACHE_ASSOC = 192;
        public const uint _SC_LEVEL2_CACHE_LINESIZE = 193;
        public const uint _SC_LEVEL3_CACHE_SIZE = 194;
        public const uint _SC_LEVEL3_CACHE_ASSOC = 195;
        public const uint _SC_LEVEL3_CACHE_LINESIZE = 196;
        public const uint _SC_LEVEL4_CACHE_SIZE = 197;
        public const uint _SC_LEVEL4_CACHE_ASSOC = 198;
        public const uint _SC_LEVEL4_CACHE_LINESIZE = 199;
        public const uint _SC_IPV6 = _SC_LEVEL1_ICACHE_SIZE + 50;
        public const uint _SC_RAW_SOCKETS = 236;
        public const uint _SC_V7_ILP32_OFF32 = 237;
        public const uint _SC_V7_ILP32_OFFBIG = 238;
        public const uint _SC_V7_LP64_OFF64 = 239;
        public const uint _SC_V7_LPBIG_OFFBIG = 240;
        public const uint _SC_SS_REPL_MAX = 241;
        public const uint _SC_TRACE_EVENT_NAME_MAX = 242;
        public const uint _SC_TRACE_NAME_MAX = 243;
        public const uint _SC_TRACE_SYS_MAX = 244;
        public const uint _SC_TRACE_USER_EVENT_MAX = 245;
        public const uint _SC_XOPEN_STREAMS = 246;
        public const uint _SC_THREAD_ROBUST_PRIO_INHERIT = 247;
        public const uint _SC_THREAD_ROBUST_PRIO_PROTECT = 248;
        public const uint _SC_MINSIGSTKSZ = 249;
        public const uint _SC_SIGSTKSZ = 250;

        public const uint _CS_PATH = 0;
        public const uint _CS_V6_WIDTH_RESTRICTED_ENVS = 1;
        public const uint _CS_GNU_LIBC_VERSION = 2;
        public const uint _CS_GNU_LIBPTHREAD_VERSION = 3;
        public const uint _CS_V5_WIDTH_RESTRICTED_ENVS = 4;
        public const uint _CS_V7_WIDTH_RESTRICTED_ENVS = 5;
        public const uint _CS_LFS_CFLAGS = 1000;
        public const uint _CS_LFS_LDFLAGS = 1001;
        public const uint _CS_LFS_LIBS = 1002;
        public const uint _CS_LFS_LINTFLAGS = 1003;
        public const uint _CS_LFS64_CFLAGS = 1004;
        public const uint _CS_LFS64_LDFLAGS = 1005;
        public const uint _CS_LFS64_LIBS = 1006;
        public const uint _CS_LFS64_LINTFLAGS = 1007;
        public const uint _CS_XBS5_ILP32_OFF32_CFLAGS = 1100;
        public const uint _CS_XBS5_ILP32_OFF32_LDFLAGS = 1101;
        public const uint _CS_XBS5_ILP32_OFF32_LIBS = 1102;
        public const uint _CS_XBS5_ILP32_OFF32_LINTFLAGS = 1103;
        public const uint _CS_XBS5_ILP32_OFFBIG_CFLAGS = 1104;
        public const uint _CS_XBS5_ILP32_OFFBIG_LDFLAGS = 1105;
        public const uint _CS_XBS5_ILP32_OFFBIG_LIBS = 1106;
        public const uint _CS_XBS5_ILP32_OFFBIG_LINTFLAGS = 1107;
        public const uint _CS_XBS5_LP64_OFF64_CFLAGS = 1108;
        public const uint _CS_XBS5_LP64_OFF64_LDFLAGS = 1109;
        public const uint _CS_XBS5_LP64_OFF64_LIBS = 1110;
        public const uint _CS_XBS5_LP64_OFF64_LINTFLAGS = 1111;
        public const uint _CS_XBS5_LPBIG_OFFBIG_CFLAGS = 1112;
        public const uint _CS_XBS5_LPBIG_OFFBIG_LDFLAGS = 1113;
        public const uint _CS_XBS5_LPBIG_OFFBIG_LIBS = 1114;
        public const uint _CS_XBS5_LPBIG_OFFBIG_LINTFLAGS = 1115;
        public const uint _CS_POSIX_V6_ILP32_OFF32_CFLAGS = 1116;
        public const uint _CS_POSIX_V6_ILP32_OFF32_LDFLAGS = 1117;
        public const uint _CS_POSIX_V6_ILP32_OFF32_LIBS = 1118;
        public const uint _CS_POSIX_V6_ILP32_OFF32_LINTFLAGS = 1119;
        public const uint _CS_POSIX_V6_ILP32_OFFBIG_CFLAGS = 1120;
        public const uint _CS_POSIX_V6_ILP32_OFFBIG_LDFLAGS = 1121;
        public const uint _CS_POSIX_V6_ILP32_OFFBIG_LIBS = 1122;
        public const uint _CS_POSIX_V6_ILP32_OFFBIG_LINTFLAGS = 1123;
        public const uint _CS_POSIX_V6_LP64_OFF64_CFLAGS = 1124;
        public const uint _CS_POSIX_V6_LP64_OFF64_LDFLAGS = 1125;
        public const uint _CS_POSIX_V6_LP64_OFF64_LIBS = 1126;
        public const uint _CS_POSIX_V6_LP64_OFF64_LINTFLAGS = 1127;
        public const uint _CS_POSIX_V6_LPBIG_OFFBIG_CFLAGS = 1128;
        public const uint _CS_POSIX_V6_LPBIG_OFFBIG_LDFLAGS = 1129;
        public const uint _CS_POSIX_V6_LPBIG_OFFBIG_LIBS = 1130;
        public const uint _CS_POSIX_V6_LPBIG_OFFBIG_LINTFLAGS = 1131;
        public const uint _CS_POSIX_V7_ILP32_OFF32_CFLAGS = 1132;
        public const uint _CS_POSIX_V7_ILP32_OFF32_LDFLAGS = 1133;
        public const uint _CS_POSIX_V7_ILP32_OFF32_LIBS = 1134;
        public const uint _CS_POSIX_V7_ILP32_OFF32_LINTFLAGS = 1135;
        public const uint _CS_POSIX_V7_ILP32_OFFBIG_CFLAGS = 1136;
        public const uint _CS_POSIX_V7_ILP32_OFFBIG_LDFLAGS = 1137;
        public const uint _CS_POSIX_V7_ILP32_OFFBIG_LIBS = 1138;
        public const uint _CS_POSIX_V7_ILP32_OFFBIG_LINTFLAGS = 1139;
        public const uint _CS_POSIX_V7_LP64_OFF64_CFLAGS = 1140;
        public const uint _CS_POSIX_V7_LP64_OFF64_LDFLAGS = 1141;
        public const uint _CS_POSIX_V7_LP64_OFF64_LIBS = 1142;
        public const uint _CS_POSIX_V7_LP64_OFF64_LINTFLAGS = 1143;
        public const uint _CS_POSIX_V7_LPBIG_OFFBIG_CFLAGS = 1144;
        public const uint _CS_POSIX_V7_LPBIG_OFFBIG_LDFLAGS = 1145;
        public const uint _CS_POSIX_V7_LPBIG_OFFBIG_LIBS = 1146;
        public const uint _CS_POSIX_V7_LPBIG_OFFBIG_LINTFLAGS = 1147;
        public const uint _CS_V6_ENV = 1148;
        public const uint _CS_V7_ENV = 1149;

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint pathconf([NativeTypeName("const char *")] sbyte* __path, int __name);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint fpathconf(int __fd, int __name);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint sysconf(int __name);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint confstr(int __name, [NativeTypeName("char *")] sbyte* __buf, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int getpid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int getppid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int getpgrp();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int __getpgid([NativeTypeName("__pid_t")] int __pid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int getpgid([NativeTypeName("__pid_t")] int __pid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setpgid([NativeTypeName("__pid_t")] int __pid, [NativeTypeName("__pid_t")] int __pgid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setpgrp();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int setsid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int getsid([NativeTypeName("__pid_t")] int __pid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__uid_t")]
        public static extern uint getuid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__uid_t")]
        public static extern uint geteuid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__gid_t")]
        public static extern uint getgid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__gid_t")]
        public static extern uint getegid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getgroups(int __size, [NativeTypeName("__gid_t[]")] uint* __list);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int group_member([NativeTypeName("__gid_t")] uint __gid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setuid([NativeTypeName("__uid_t")] uint __uid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setreuid([NativeTypeName("__uid_t")] uint __ruid, [NativeTypeName("__uid_t")] uint __euid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int seteuid([NativeTypeName("__uid_t")] uint __uid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setgid([NativeTypeName("__gid_t")] uint __gid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setregid([NativeTypeName("__gid_t")] uint __rgid, [NativeTypeName("__gid_t")] uint __egid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setegid([NativeTypeName("__gid_t")] uint __gid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getresuid([NativeTypeName("__uid_t *")] uint* __ruid, [NativeTypeName("__uid_t *")] uint* __euid, [NativeTypeName("__uid_t *")] uint* __suid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getresgid([NativeTypeName("__gid_t *")] uint* __rgid, [NativeTypeName("__gid_t *")] uint* __egid, [NativeTypeName("__gid_t *")] uint* __sgid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setresuid([NativeTypeName("__uid_t")] uint __ruid, [NativeTypeName("__uid_t")] uint __euid, [NativeTypeName("__uid_t")] uint __suid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setresgid([NativeTypeName("__gid_t")] uint __rgid, [NativeTypeName("__gid_t")] uint __egid, [NativeTypeName("__gid_t")] uint __sgid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int fork();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int _Fork();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ttyname(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ttyname_r(int __fd, [NativeTypeName("char *")] sbyte* __buf, [NativeTypeName("size_t")] nuint __buflen);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int isatty(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ttyslot();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int link([NativeTypeName("const char *")] sbyte* __from, [NativeTypeName("const char *")] sbyte* __to);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int linkat(int __fromfd, [NativeTypeName("const char *")] sbyte* __from, int __tofd, [NativeTypeName("const char *")] sbyte* __to, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int symlink([NativeTypeName("const char *")] sbyte* __from, [NativeTypeName("const char *")] sbyte* __to);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint readlink([NativeTypeName("const char *__restrict")] sbyte* __path, [NativeTypeName("char *__restrict")] sbyte* __buf, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int symlinkat([NativeTypeName("const char *")] sbyte* __from, int __tofd, [NativeTypeName("const char *")] sbyte* __to);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint readlinkat(int __fd, [NativeTypeName("const char *__restrict")] sbyte* __path, [NativeTypeName("char *__restrict")] sbyte* __buf, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int unlink([NativeTypeName("const char *")] sbyte* __name);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int unlinkat(int __fd, [NativeTypeName("const char *")] sbyte* __name, int __flag);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rmdir([NativeTypeName("const char *")] sbyte* __path);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int tcgetpgrp(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int tcsetpgrp(int __fd, [NativeTypeName("__pid_t")] int __pgrp_id);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* getlogin();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getlogin_r([NativeTypeName("char *")] sbyte* __name, [NativeTypeName("size_t")] nuint __name_len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setlogin([NativeTypeName("const char *")] sbyte* __name);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getopt(int ___argc, [NativeTypeName("char *const *")] sbyte** ___argv, [NativeTypeName("const char *")] sbyte* __shortopts);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int gethostname([NativeTypeName("char *")] sbyte* __name, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sethostname([NativeTypeName("const char *")] sbyte* __name, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sethostid([NativeTypeName("long")] nint __id);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getdomainname([NativeTypeName("char *")] sbyte* __name, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setdomainname([NativeTypeName("const char *")] sbyte* __name, [NativeTypeName("size_t")] nuint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vhangup();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int revoke([NativeTypeName("const char *")] sbyte* __file);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int profil([NativeTypeName("unsigned short *")] ushort* __sample_buffer, [NativeTypeName("size_t")] nuint __size, [NativeTypeName("size_t")] nuint __offset, [NativeTypeName("unsigned int")] uint __scale);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int acct([NativeTypeName("const char *")] sbyte* __name);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* getusershell();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void endusershell();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void setusershell();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int daemon(int __nochdir, int __noclose);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chroot([NativeTypeName("const char *")] sbyte* __path);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* getpass([NativeTypeName("const char *")] sbyte* __prompt);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fsync(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int syncfs(int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint gethostid();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sync();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getpagesize();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getdtablesize();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int truncate([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("__off_t")] nint __length);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int truncate64([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("__off64_t")] nint __length);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ftruncate(int __fd, [NativeTypeName("__off_t")] nint __length);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ftruncate64(int __fd, [NativeTypeName("__off64_t")] nint __length);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int brk(void* __addr);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* sbrk([NativeTypeName("intptr_t")] nint __delta);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint syscall([NativeTypeName("long")] nint __sysno, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lockf(int __fd, int __cmd, [NativeTypeName("__off_t")] nint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lockf64(int __fd, int __cmd, [NativeTypeName("__off64_t")] nint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern nint copy_file_range(int __infd, [NativeTypeName("__off64_t *")] nint* __pinoff, int __outfd, [NativeTypeName("__off64_t *")] nint* __poutoff, [NativeTypeName("size_t")] nuint __length, [NativeTypeName("unsigned int")] uint __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fdatasync(int __fildes);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* crypt([NativeTypeName("const char *")] sbyte* __key, [NativeTypeName("const char *")] sbyte* __salt);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void swab([NativeTypeName("const void *__restrict")] void* __from, [NativeTypeName("void *__restrict")] void* __to, [NativeTypeName("ssize_t")] nint __n);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getentropy(void* __buffer, [NativeTypeName("size_t")] nuint __length);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int close_range([NativeTypeName("unsigned int")] uint __fd, [NativeTypeName("unsigned int")] uint __max_fd, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int gettid();

        public const int SI_ASYNCNL = -60;
        public const int SI_DETHREAD = -7;
        public const int SI_TKILL = -6;
        public const int SI_SIGIO = -5;
        public const int SI_ASYNCIO = -4;
        public const int SI_MESGQ = -3;
        public const int SI_TIMER = -2;
        public const int SI_QUEUE = -1;
        public const int SI_USER = 0;
        public const int SI_KERNEL = 0x80;

        public const uint ILL_ILLOPC = 1;
        public const uint ILL_ILLOPN = 2;
        public const uint ILL_ILLADR = 3;
        public const uint ILL_ILLTRP = 4;
        public const uint ILL_PRVOPC = 5;
        public const uint ILL_PRVREG = 6;
        public const uint ILL_COPROC = 7;
        public const uint ILL_BADSTK = 8;
        public const uint ILL_BADIADDR = 9;

        public const uint FPE_INTDIV = 1;
        public const uint FPE_INTOVF = 2;
        public const uint FPE_FLTDIV = 3;
        public const uint FPE_FLTOVF = 4;
        public const uint FPE_FLTUND = 5;
        public const uint FPE_FLTRES = 6;
        public const uint FPE_FLTINV = 7;
        public const uint FPE_FLTSUB = 8;
        public const uint FPE_FLTUNK = 14;
        public const uint FPE_CONDTRAP = 15;

        public const uint SEGV_MAPERR = 1;
        public const uint SEGV_ACCERR = 2;
        public const uint SEGV_BNDERR = 3;
        public const uint SEGV_PKUERR = 4;
        public const uint SEGV_ACCADI = 5;
        public const uint SEGV_ADIDERR = 6;
        public const uint SEGV_ADIPERR = 7;
        public const uint SEGV_MTEAERR = 8;
        public const uint SEGV_MTESERR = 9;
        public const uint SEGV_CPERR = 10;

        public const uint BUS_ADRALN = 1;
        public const uint BUS_ADRERR = 2;
        public const uint BUS_OBJERR = 3;
        public const uint BUS_MCEERR_AR = 4;
        public const uint BUS_MCEERR_AO = 5;

        public const uint TRAP_BRKPT = 1;
        public const uint TRAP_TRACE = 2;
        public const uint TRAP_BRANCH = 3;
        public const uint TRAP_HWBKPT = 4;
        public const uint TRAP_UNK = 5;

        public const uint CLD_EXITED = 1;
        public const uint CLD_KILLED = 2;
        public const uint CLD_DUMPED = 3;
        public const uint CLD_TRAPPED = 4;
        public const uint CLD_STOPPED = 5;
        public const uint CLD_CONTINUED = 6;

        public const uint POLL_IN = 1;
        public const uint POLL_OUT = 2;
        public const uint POLL_MSG = 3;
        public const uint POLL_ERR = 4;
        public const uint POLL_PRI = 5;
        public const uint POLL_HUP = 6;

        public const uint SIGEV_SIGNAL = 0;
        public const uint SIGEV_NONE = 1;
        public const uint SIGEV_THREAD = 2;
        public const uint SIGEV_THREAD_ID = 4;

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged[Cdecl]<int, void> __sysv_signal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged[Cdecl]<int, void> __handler);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged[Cdecl]<int, void> sysv_signal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged[Cdecl]<int, void> __handler);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged[Cdecl]<int, void> signal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged[Cdecl]<int, void> __handler);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int kill([NativeTypeName("__pid_t")] int __pid, int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int killpg([NativeTypeName("__pid_t")] int __pgrp, int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int raise(int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged[Cdecl]<int, void> ssignal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged[Cdecl]<int, void> __handler);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int gsignal(int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void psignal(int __sig, [NativeTypeName("const char *")] sbyte* __s);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void psiginfo([NativeTypeName("const siginfo_t *")] siginfo_t* __pinfo, [NativeTypeName("const char *")] sbyte* __s);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete("Use the sigsuspend function instead")]
        public static extern int sigpause(int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int sigblock(int __mask);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int sigsetmask(int __mask);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int siggetmask();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigemptyset([NativeTypeName("sigset_t *")] __sigset_t* __set);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigfillset([NativeTypeName("sigset_t *")] __sigset_t* __set);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigaddset([NativeTypeName("sigset_t *")] __sigset_t* __set, int __signo);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigdelset([NativeTypeName("sigset_t *")] __sigset_t* __set, int __signo);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigismember([NativeTypeName("const sigset_t *")] __sigset_t* __set, int __signo);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigisemptyset([NativeTypeName("const sigset_t *")] __sigset_t* __set);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigandset([NativeTypeName("sigset_t *")] __sigset_t* __set, [NativeTypeName("const sigset_t *")] __sigset_t* __left, [NativeTypeName("const sigset_t *")] __sigset_t* __right);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigorset([NativeTypeName("sigset_t *")] __sigset_t* __set, [NativeTypeName("const sigset_t *")] __sigset_t* __left, [NativeTypeName("const sigset_t *")] __sigset_t* __right);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigprocmask(int __how, [NativeTypeName("const sigset_t *")] __sigset_t* __set, [NativeTypeName("sigset_t *")] __sigset_t* __oset);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigsuspend([NativeTypeName("const sigset_t *")] __sigset_t* __set);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigaction(int __sig, [NativeTypeName("const struct sigaction *__restrict")] sigaction* __act, [NativeTypeName("struct sigaction *__restrict")] sigaction* __oact);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigpending([NativeTypeName("sigset_t *")] __sigset_t* __set);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigwait([NativeTypeName("const sigset_t *")] __sigset_t* __set, [NativeTypeName("int *__restrict")] int* __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigwaitinfo([NativeTypeName("const sigset_t *")] __sigset_t* __set, siginfo_t* __info);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigtimedwait([NativeTypeName("const sigset_t *")] __sigset_t* __set, siginfo_t* __info, [NativeTypeName("const struct timespec *__restrict")] timespec* __timeout);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigqueue([NativeTypeName("__pid_t")] int __pid, int __sig, [NativeTypeName("const union sigval")] sigval __val);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigreturn([NativeTypeName("struct sigcontext *")] sigcontext* __scp);

        public const uint REG_R8 = 0;
        public const uint REG_R9 = 1;
        public const uint REG_R10 = 2;
        public const uint REG_R11 = 3;
        public const uint REG_R12 = 4;
        public const uint REG_R13 = 5;
        public const uint REG_R14 = 6;
        public const uint REG_R15 = 7;
        public const uint REG_RDI = 8;
        public const uint REG_RSI = 9;
        public const uint REG_RBP = 10;
        public const uint REG_RBX = 11;
        public const uint REG_RDX = 12;
        public const uint REG_RAX = 13;
        public const uint REG_RCX = 14;
        public const uint REG_RSP = 15;
        public const uint REG_RIP = 16;
        public const uint REG_EFL = 17;
        public const uint REG_CSGSFS = 18;
        public const uint REG_ERR = 19;
        public const uint REG_TRAPNO = 20;
        public const uint REG_OLDMASK = 21;
        public const uint REG_CR2 = 22;

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete("Use sigaction with SA_RESTART instead")]
        public static extern int siginterrupt(int __sig, int __interrupt);

        public const uint SS_ONSTACK = 1;
        public const uint SS_DISABLE = 2;

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sigaltstack([NativeTypeName("const stack_t *__restrict")] stack_t* __ss, stack_t* __oss);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete("Use the sigprocmask function instead")]
        public static extern int sighold(int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete("Use the sigprocmask function instead")]
        public static extern int sigrelse(int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete("Use the signal function instead")]
        public static extern int sigignore(int __sig);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        [Obsolete("Use the signal and sigprocmask functions instead")]
        public static extern delegate* unmanaged[Cdecl]<int, void> sigset(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged[Cdecl]<int, void> __disp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pthread_sigmask(int __how, [NativeTypeName("const __sigset_t *__restrict")] __sigset_t* __newmask, __sigset_t* __oldmask);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pthread_kill([NativeTypeName("pthread_t")] nuint __threadid, int __signo);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pthread_sigqueue([NativeTypeName("pthread_t")] nuint __threadid, int __signo, [NativeTypeName("const union sigval")] sigval __value);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int __libc_current_sigrtmin();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int __libc_current_sigrtmax();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int tgkill([NativeTypeName("__pid_t")] int __tgid, [NativeTypeName("__pid_t")] int __tid, int __signal);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int wait(int* __stat_loc);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int waitpid([NativeTypeName("__pid_t")] int __pid, int* __stat_loc, int __options);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int waitid(idtype_t __idtype, [NativeTypeName("__id_t")] uint __id, siginfo_t* __infop, int __options);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int wait3(int* __stat_loc, int __options, [NativeTypeName("struct rusage *")] rusage* __usage);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__pid_t")]
        public static extern int wait4([NativeTypeName("__pid_t")] int __pid, int* __stat_loc, int __options, [NativeTypeName("struct rusage *")] rusage* __usage);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__ssize_t")]
        public static extern nint readahead(int __fd, [NativeTypeName("__off64_t")] nint __offset, [NativeTypeName("size_t")] nuint __count);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sync_file_range(int __fd, [NativeTypeName("__off64_t")] nint __offset, [NativeTypeName("__off64_t")] nint __count, [NativeTypeName("unsigned int")] uint __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__ssize_t")]
        public static extern nint vmsplice(int __fdout, [NativeTypeName("const struct iovec *")] iovec* __iov, [NativeTypeName("size_t")] nuint __count, [NativeTypeName("unsigned int")] uint __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__ssize_t")]
        public static extern nint splice(int __fdin, [NativeTypeName("__off64_t *")] nint* __offin, int __fdout, [NativeTypeName("__off64_t *")] nint* __offout, [NativeTypeName("size_t")] nuint __len, [NativeTypeName("unsigned int")] uint __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__ssize_t")]
        public static extern nint tee(int __fdin, int __fdout, [NativeTypeName("size_t")] nuint __len, [NativeTypeName("unsigned int")] uint __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fallocate(int __fd, int __mode, [NativeTypeName("__off_t")] nint __offset, [NativeTypeName("__off_t")] nint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fallocate64(int __fd, int __mode, [NativeTypeName("__off64_t")] nint __offset, [NativeTypeName("__off64_t")] nint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int name_to_handle_at(int __dfd, [NativeTypeName("const char *")] sbyte* __name, [NativeTypeName("struct file_handle *")] file_handle* __handle, int* __mnt_id, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int open_by_handle_at(int __mountdirfd, [NativeTypeName("struct file_handle *")] file_handle* __handle, int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fcntl(int __fd, int __cmd, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fcntl64(int __fd, int __cmd, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int open([NativeTypeName("const char *")] sbyte* __file, int __oflag, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int open64([NativeTypeName("const char *")] sbyte* __file, int __oflag, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int openat(int __fd, [NativeTypeName("const char *")] sbyte* __file, int __oflag, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int openat64(int __fd, [NativeTypeName("const char *")] sbyte* __file, int __oflag, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int creat([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("mode_t")] uint __mode);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int creat64([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("mode_t")] uint __mode);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_fadvise(int __fd, [NativeTypeName("off_t")] nint __offset, [NativeTypeName("off_t")] nint __len, int __advise);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_fadvise64(int __fd, [NativeTypeName("off64_t")] nint __offset, [NativeTypeName("off64_t")] nint __len, int __advise);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_fallocate(int __fd, [NativeTypeName("off_t")] nint __offset, [NativeTypeName("off_t")] nint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_fallocate64(int __fd, [NativeTypeName("off64_t")] nint __offset, [NativeTypeName("off64_t")] nint __len);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int clone([NativeTypeName("int (*)(void *)")] delegate* unmanaged[Cdecl]<void*, int> __fn, void* __child_stack, int __flags, void* __arg, __arglist);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int unshare(int __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_getcpu();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int getcpu([NativeTypeName("unsigned int *")] uint* param0, [NativeTypeName("unsigned int *")] uint* param1);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int setns(int __fd, int __nstype);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int __sched_cpucount([NativeTypeName("size_t")] nuint __setsize, [NativeTypeName("const cpu_set_t *")] cpu_set_t* __setp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cpu_set_t* __sched_cpualloc([NativeTypeName("size_t")] nuint __count);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void __sched_cpufree(cpu_set_t* __set);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_setparam([NativeTypeName("__pid_t")] int __pid, [NativeTypeName("const struct sched_param *")] sched_param* __param);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_getparam([NativeTypeName("__pid_t")] int __pid, [NativeTypeName("struct sched_param *")] sched_param* __param);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_setscheduler([NativeTypeName("__pid_t")] int __pid, int __policy, [NativeTypeName("const struct sched_param *")] sched_param* __param);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_getscheduler([NativeTypeName("__pid_t")] int __pid);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_yield();

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_get_priority_max(int __algorithm);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_get_priority_min(int __algorithm);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_rr_get_interval([NativeTypeName("__pid_t")] int __pid, [NativeTypeName("struct timespec *")] timespec* __t);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_setaffinity([NativeTypeName("__pid_t")] int __pid, [NativeTypeName("size_t")] nuint __cpusetsize, [NativeTypeName("const cpu_set_t *")] cpu_set_t* __cpuset);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sched_getaffinity([NativeTypeName("__pid_t")] int __pid, [NativeTypeName("size_t")] nuint __cpusetsize, cpu_set_t* __cpuset);

        [return: NativeTypeName("__uint16_t")]
        public static ushort __bswap_16([NativeTypeName("__uint16_t")] ushort __bsx)
        {
            return ((ushort)((((__bsx) >> 8) & 0xff) | (((__bsx) & 0xff) << 8)));
        }

        [return: NativeTypeName("__uint32_t")]
        public static uint __bswap_32([NativeTypeName("__uint32_t")] uint __bsx)
        {
            return ((((__bsx) & 0xff000000U) >> 24) | (((__bsx) & 0x00ff0000U) >> 8) | (((__bsx) & 0x0000ff00U) << 8) | (((__bsx) & 0x000000ffU) << 24));
        }

        [return: NativeTypeName("__uint64_t")]
        public static ulong __bswap_64([NativeTypeName("__uint64_t")] ulong __bsx)
        {
            return ((((__bsx) & 0xff00000000000000UL) >> 56) | (((__bsx) & 0x00ff000000000000UL) >> 40) | (((__bsx) & 0x0000ff0000000000UL) >> 24) | (((__bsx) & 0x000000ff00000000UL) >> 8) | (((__bsx) & 0x00000000ff000000UL) << 8) | (((__bsx) & 0x0000000000ff0000UL) << 24) | (((__bsx) & 0x000000000000ff00UL) << 40) | (((__bsx) & 0x00000000000000ffUL) << 56));
        }

        [return: NativeTypeName("__uint16_t")]
        public static ushort __uint16_identity([NativeTypeName("__uint16_t")] ushort __x)
        {
            return __x;
        }

        [return: NativeTypeName("__uint32_t")]
        public static uint __uint32_identity([NativeTypeName("__uint32_t")] uint __x)
        {
            return __x;
        }

        [return: NativeTypeName("__uint64_t")]
        public static ulong __uint64_identity([NativeTypeName("__uint64_t")] ulong __x)
        {
            return __x;
        }

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int select(int __nfds, fd_set* __readfds, fd_set* __writefds, fd_set* __exceptfds, [NativeTypeName("struct timeval *__restrict")] timeval* __timeout);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pselect(int __nfds, fd_set* __readfds, fd_set* __writefds, fd_set* __exceptfds, [NativeTypeName("const struct timespec *__restrict")] timespec* __timeout, [NativeTypeName("const __sigset_t *__restrict")] __sigset_t* __sigmask);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn([NativeTypeName("pid_t *")] int* __pid, [NativeTypeName("const char *__restrict")] sbyte* __path, [NativeTypeName("const posix_spawn_file_actions_t *__restrict")] posix_spawn_file_actions_t* __file_actions, [NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attrp, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnp([NativeTypeName("pid_t *")] int* __pid, [NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("const posix_spawn_file_actions_t *")] posix_spawn_file_actions_t* __file_actions, [NativeTypeName("const posix_spawnattr_t *")] posix_spawnattr_t* __attrp, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_init(posix_spawnattr_t* __attr);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_destroy(posix_spawnattr_t* __attr);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getsigdefault([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("sigset_t *")] __sigset_t* __sigdefault);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setsigdefault(posix_spawnattr_t* __attr, [NativeTypeName("const sigset_t *")] __sigset_t* __sigdefault);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getsigmask([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("sigset_t *")] __sigset_t* __sigmask);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setsigmask(posix_spawnattr_t* __attr, [NativeTypeName("const sigset_t *")] __sigset_t* __sigmask);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getflags([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("short *__restrict")] short* __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setflags(posix_spawnattr_t* _attr, short __flags);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getpgroup([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("pid_t *")] int* __pgroup);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setpgroup(posix_spawnattr_t* __attr, [NativeTypeName("pid_t")] int __pgroup);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getschedpolicy([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("int *__restrict")] int* __schedpolicy);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setschedpolicy(posix_spawnattr_t* __attr, int __schedpolicy);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getschedparam([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("struct sched_param *__restrict")] sched_param* __schedparam);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setschedparam(posix_spawnattr_t* __attr, [NativeTypeName("const struct sched_param *__restrict")] sched_param* __schedparam);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_init(posix_spawn_file_actions_t* __file_actions);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_destroy(posix_spawn_file_actions_t* __file_actions);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_addopen(posix_spawn_file_actions_t* __file_actions, int __fd, [NativeTypeName("const char *__restrict")] sbyte* __path, int __oflag, [NativeTypeName("mode_t")] uint __mode);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_addclose(posix_spawn_file_actions_t* __file_actions, int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_adddup2(posix_spawn_file_actions_t* __file_actions, int __fd, int __newfd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_addchdir_np(posix_spawn_file_actions_t* __actions, [NativeTypeName("const char *__restrict")] sbyte* __path);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_addfchdir_np(posix_spawn_file_actions_t* param0, int __fd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_addclosefrom_np(posix_spawn_file_actions_t* param0, int __from);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawn_file_actions_addtcsetpgrp_np(posix_spawn_file_actions_t* param0, int __tcfd);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_getcgroup_np([NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attr, [NativeTypeName("int *__restrict")] int* __cgroup);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int posix_spawnattr_setcgroup_np(posix_spawnattr_t* __attr, int __cgroup);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pidfd_spawn([NativeTypeName("int *__restrict")] int* __pidfd, [NativeTypeName("const char *__restrict")] sbyte* __path, [NativeTypeName("const posix_spawn_file_actions_t *__restrict")] posix_spawn_file_actions_t* __facts, [NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attrp, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pidfd_spawnp([NativeTypeName("int *__restrict")] int* __pidfd, [NativeTypeName("const char *__restrict")] sbyte* __file, [NativeTypeName("const posix_spawn_file_actions_t *__restrict")] posix_spawn_file_actions_t* __facts, [NativeTypeName("const posix_spawnattr_t *__restrict")] posix_spawnattr_t* __attrp, [NativeTypeName("char *const[]")] sbyte** __argv, [NativeTypeName("char *const[]")] sbyte** __envp);
    }
}
