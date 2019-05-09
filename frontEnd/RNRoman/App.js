import React, { Component } from 'react';
import { Button, StyleSheet, Text, View } from 'react-native';

import { createSwitchNavigator, createAppContainer, createDrawerNavigator } from 'react-navigation';

import HomeAdm from './src/pages/homeadm';
import GerenciarTipoUsuario from './src/pages/gerenciartipousuario';
import Equipes from './src/pages/equipes';
import GerenciarUsuarios from './src/pages/gerenciarusuarios';
import CadastrarUsuario from './src/pages/cadastrarusuario';
import Temas from './src/pages/temas';
import HomePro from './src/pages/homepro';
import GerenciarProjetos from './src/pages/gerenciarprojetos';
import CadastrarProjeto from './src/pages/cadastrarprojeto';

class App extends Component {
    render() {
        return (
            <AppContainer />
        )
    }
}

export default App;

class TelaInicial extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Button 
                    title='Ir para Home Adm' 
                    onPress={() => this.props.navigation.navigate('Home Adm')}/>
                <Button 
                    title='Ir para Home Pro' 
                    onPress={() => this.props.navigation.navigate('Home Pro')}/>
            </View>
        )
    }
}

const ProDrawerNavigator = createDrawerNavigator({
    'Tela Inicial': { screen: TelaInicial },
    'Home Pro': HomePro,
    'Gerenciar Projetos': GerenciarProjetos,
    'Cadastrar Projeto': CadastrarProjeto,
    Temas: Temas
})

const AdmDrawerNavigator = createDrawerNavigator({
    'Tela Inicial': { screen: TelaInicial },
    'Home Adm': HomeAdm,
    'Gerenciar Tipo Usuario': GerenciarTipoUsuario,
    Equipes: Equipes,
    'Gerenciar Usuarios': GerenciarUsuarios,
    'Cadastrar Usuario': CadastrarUsuario,
    Temas: Temas
})

const AppSwitchNavigator = createSwitchNavigator({
    'Home Adm': { screen: AdmDrawerNavigator },
    'Home Pro': { screen: ProDrawerNavigator }
})

const AppContainer = createAppContainer(AppSwitchNavigator);

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'space-around',
    },
});