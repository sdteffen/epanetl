Name: epanet
Version: 2.0.12
Release: 3
Vendor: epanet.de
License: GPL
Summary: EPANET models water distribution piping systems
Group: Productivity/Other
Packager: Steffen Macke <sdteffen@sdteffen.de>
BuildRoot:  %{_tmppath}/%{name}-%{version}-build 
Source: %{name}-%{version}.tar.gz
Url: http://epanet.de
BuildRequires: glibc-devel 

%description
EPANET models water distribution piping systems (hydraulic analysis).

%prep
%setup

%build
./configure --prefix=/usr --libdir=%_libdir
make

%install
rm -rf %{buildroot}
%makeinstall

%clean
rm -rf %{buildroot}

%post -p /sbin/ldconfig
%postun -p /sbin/ldconfig
%files
%defattr(-, root, root)
%doc AUTHORS COPYING ChangeLog NEWS README TODO
/usr/bin/epanet2
/usr/share/locale/de/LC_MESSAGES/epanet.mo

%package devel
Summary: EPANET developer files
Group: Productivity/Other
%description
EPANET developer files: Header files and libraries

%files
/usr/include/toolkit.h
%_libdir/libepanet2.so
%_libdir/libepanet2.so.0
%_libdir/libepanet2.so.0.0.0
%_libdir/libepanet2.a
%_libdir/libepanet2.la

%changelog
* Tue Nov 09 2010 - Steffen Macke <sdteffen@sdteffen.de>
- Updates for openSUSE 11.3
* Fri Jul 18 2008 - Steffen Macke <sdteffen@sdteffen.de>
- Initial RPM build for version 2.0.12

