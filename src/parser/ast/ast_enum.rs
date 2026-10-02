#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum DeclarationKind {
    Declare,
    Export,
    Local,
    Readonly,
    Typeset,
}

#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum ListOperator {
    Sequence,
    Background,
    LogicalAnd,
    LogicalOr,
}

#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum LoopKind {
    While,
    Until,
}

#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum PipeOperator {
    Pipe,
    PipeStderr,
}

#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum ProcessSubstitutionKind {
    Input,
    Output,
}

#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum RedirectionKind {
    Input,
    InputDuplicate,
    InputClose,
    Heredoc,
    HeredocStripTabs,
    Herestring,
    Output,
    OutputDuplicate,
    OutputClose,
    OutputAppend,
    OutputClobber,
    StdoutStderr,
    StdoutStderrAppend,
}

impl RedirectionKind {
    pub fn symbol(&self) -> &'static str {
        match self {
            Self::Input => "<",
            Self::InputDuplicate => "<&",
            Self::InputClose => "<&-",
            Self::Heredoc => "<<",
            Self::HeredocStripTabs => "<<-",
            Self::Herestring => "<<<",
            Self::Output => ">",
            Self::OutputDuplicate => ">&",
            Self::OutputClose => ">&-",
            Self::OutputAppend => ">>",
            Self::OutputClobber => ">|",
            Self::StdoutStderr => "&>",
            Self::StdoutStderrAppend => "&>>",
        }
    }

    pub fn from_symbol(symbol: &str) -> Self {
        match symbol {
            "<" => Self::Input,
            "<&" => Self::InputDuplicate,
            "<&-" => Self::InputClose,
            "<<" => Self::Heredoc,
            "<<-" => Self::HeredocStripTabs,
            "<<<" => Self::Herestring,
            ">" => Self::Output,
            ">&" => Self::OutputDuplicate,
            ">&-" => Self::OutputClose,
            ">>" => Self::OutputAppend,
            ">|" => Self::OutputClobber,
            "&>" => Self::StdoutStderr,
            "&>>" => Self::StdoutStderrAppend,
            _ => panic!("Unknown redirection operator: {}", symbol),
        }
    }
}
