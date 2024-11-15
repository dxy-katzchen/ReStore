import { AppBar, Switch, Toolbar, Typography } from "@mui/material";

interface Props {
  darkMode: boolean;
  toggleDarkMode: (darkMode: boolean) => void;
}

export default function Header({ darkMode, toggleDarkMode }: Props) {
  return (
    <AppBar position="static" sx={{ mb: 4 }}>
      <Toolbar>
        <Typography variant="h6">RE-STORE</Typography>
        <Switch checked={darkMode} onChange={() => toggleDarkMode(!darkMode)} />
      </Toolbar>
    </AppBar>
  );
}
