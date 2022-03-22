#!/bin/bash
printf "\033c"

Red_Error() {
  echo '================================================='
  printf '\033[1;31;40m%b\033[0m\n' "$@"
  echo '================================================='
  exit 1
}

Uninstall_OpenFrp() {
  openfrp_install_path="/opt/OpenFrp"
  echo "即将开始删除OpenFrp.Linux"
  sleep 3

  echo "[x] rm -irf ${openfrp_install_path}"
  rm -irf ${openfrp_install_path}

  echo "rm -irf /usr/bin/frpc"
  rm -irf /usr/bin/frpc

  echo "rm -irf /usr/bin/openfrp"
  rm -irf /usr/bin/openfrp

  Finish
}


Finish() {
  echo "OpenFrp.Linux 已卸载完成"
  exit
}

echo "+---------------------------------------------------------------------
| OpenFrp.Linux Uninstall
+----------------------------------------------------------------------
| Shell Uninstall Script by OldGodShen
+----------------------------------------------------------------------
"

Uninstall_OpenFrp